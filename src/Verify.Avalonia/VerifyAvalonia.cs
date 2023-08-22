using Avalonia.Headless;

namespace VerifyTests;

public static partial class VerifyAvalonia
{
    public static bool Initialized { get; private set; }

    public static void WriteAvaloniaMember(this VerifyJsonWriter writer, Visual target, object? value, string name)
    {
        if (IsMemberValueInherited(target, name, value))
        {
            return;
        }
        writer.WriteMember(target, value, name);
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