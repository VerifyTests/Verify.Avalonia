using System.Collections.Concurrent;

static class CommandNameResolver
{
    public static string GetCommandName(ICommand command)
    {
        var type = command.GetType();

        // Try to get the execute delegate from common ICommand implementations
        // CommunityToolkit.Mvvm RelayCommand stores the action in a field named "execute"
        var executeField = type.GetField("execute", BindingFlags.NonPublic | BindingFlags.Instance);
        if (executeField != null)
        {
            var execute = executeField.GetValue(command);
            if (execute is Delegate {Method.DeclaringType: not null} del)
            {
                return $"{del.Method.DeclaringType.Name}.{del.Method.Name}";
            }
        }

        // Try common field names used by other ICommand implementations
        foreach (var fieldName in new[] { "_execute", "_executeMethod", "executeAction" })
        {
            var field = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                var fieldValue = field.GetValue(command);
                if (fieldValue is Delegate {Method.DeclaringType: not null} del)
                {
                    return $"{del.Method.DeclaringType.Name}.{del.Method.Name}";
                }
            }
        }

        // Fallback: return the command type name
        return type.Name;
    }
}

/// <summary>
/// Converter that handles objects with ICommand properties by serializing them manually.
/// This avoids Argon's contract creation which triggers TypeLoadException for ICommand.
/// </summary>
class CommandAwareObjectConverter : WriteOnlyJsonConverter
{
    static readonly ConcurrentDictionary<Type, bool> hasCommandPropertiesCache = new();

    public override bool CanConvert(Type type) =>
        !type.IsPrimitive &&
        type != typeof(string) &&
        !typeof(ICommand).IsAssignableFrom(type) &&
        !typeof(AvaloniaObject).IsAssignableFrom(type) &&
        HasCommandProperties(type);

    static bool HasCommandProperties(Type type) =>
        hasCommandPropertiesCache.GetOrAdd(type, t =>
            t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Any(p => typeof(ICommand).IsAssignableFrom(p.PropertyType)));

    public override void Write(VerifyJsonWriter writer, object value)
    {
        var type = value.GetType();
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.CanRead && p.GetIndexParameters().Length == 0);

        writer.WriteStartObject();

        foreach (var prop in properties)
        {
            try
            {
                var propValue = prop.GetValue(value);
                if (propValue == null)
                {
                    continue;
                }

                // Handle ICommand properties specially
                if (propValue is ICommand command)
                {
                    writer.WriteMember(value, CommandNameResolver.GetCommandName(command), prop.Name);
                }
                else
                {
                    writer.WriteMember(value, propValue, prop.Name);
                }
            }
            catch (TypeLoadException)
            {
                // Skip properties that cause TypeLoadException
            }
        }

        writer.WriteEndObject();
    }
}

