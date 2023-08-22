using Avalonia.Data;
using Avalonia.Diagnostics;

namespace VerifyTests;

public class AvaloniaConverter<T> :
    WriteOnlyJsonConverter<T>
    where T : AvaloniaObject
{
    static AvaloniaProperty[] properties =
        AvaloniaPropertyRegistry
            .Instance.GetRegistered(typeof(T))
            .Where(_ => !_.IsReadOnly &&
                        _.Name != "Name")
            .ToArray();

    public override void Write(VerifyJsonWriter writer, T value)
    {
        writer.WriteStartObject();
        foreach (var property in properties)
        {
            var diagnostic = value.GetDiagnostic(property);
            if (diagnostic.Priority == BindingPriority.LocalValue)
            {
                writer.WriteMember(value, diagnostic.Value, property.Name);
            }
        }

        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        writer.WriteEndObject();
    }
}