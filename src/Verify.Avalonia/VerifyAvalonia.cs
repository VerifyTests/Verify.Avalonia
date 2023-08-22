using Avalonia.Data;
using Avalonia.Diagnostics;
using Avalonia.Headless;

namespace VerifyTests;

public static partial class VerifyAvalonia
{
    public static bool Initialized { get; private set; }

    public static bool ShouldIncludeProperty(this AvaloniaObject target, AvaloniaProperty property)
    {
        var diagnostic = target.GetDiagnostic(property);
        return diagnostic.Priority == BindingPriority.LocalValue;
    }

    public static bool ShouldIncludeProperty<T>(this StyledProperty<T> property, AvaloniaObject target, T value)
    {
        var diagnostic = target.GetDiagnostic(property);
        if (diagnostic.Priority != BindingPriority.LocalValue)
        {
            return false;
        }

        return !Equals(property.GetDefaultValue(target.GetType()), value);
    }

    public static bool ShouldIncludeProperty<T>(this DirectPropertyBase<T> property, AvaloniaObject target, T value)
    {
        var diagnostic = target.GetDiagnostic(property);
        if (diagnostic.Priority != BindingPriority.LocalValue)
        {
            return false;
        }

        return !Equals(property.GetUnsetValue(target.GetType()), value);
    }

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();
        VerifierSettings.RegisterFileConverter<TopLevel>(TopLevelToImage);
        AddConverters();

        VerifierSettings.AddExtraSettings(
            _ =>
            {
                _.Converters.Add(new ThicknessConverter());
                _.Converters.Add(new CornerRadiusConverter());
                _.Converters.Add(new FontFamilyConverter());
            });
    }

    static ConversionResult TopLevelToImage(TopLevel topLevel, IReadOnlyDictionary<string, object> context)
    {
        using var bitmap = topLevel.CaptureRenderedFrame();
        var stream = new MemoryStream();
        if (bitmap == null)
        {
            throw new("No RenderedFrame");
        }

        bitmap.Save(stream);
        return new(
            topLevel,
            new List<Target>
            {
                new("png", stream)
            });
    }

    internal static void WriteGeneratedMembers(VerifyJsonWriter writer, object value)
    {
        var type = value.GetType();
        foreach (var field in type.GetFields(
                     BindingFlags.Instance | BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
        {
            if (!field.IsAssembly)
            {
                continue;
            }

            var fieldValue = field.GetValue(value);
            writer.WriteMember(value, fieldValue, field.Name);
        }
    }
}