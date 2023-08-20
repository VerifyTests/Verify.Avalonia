using Avalonia.Headless;

namespace VerifyTests;

public static partial class VerifyAvalonia
{
    public static bool Initialized { get; private set; }

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
}