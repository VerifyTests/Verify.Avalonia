using Avalonia.Controls;
using Avalonia.Headless;

namespace VerifyTests;

public static class VerifyAvalonia
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
    }

    static ConversionResult TopLevelToImage(TopLevel topLevel, IReadOnlyDictionary<string, object> context)
    {
        var bitmap = topLevel.CaptureRenderedFrame();
        var memoryStream = new MemoryStream();
        if (bitmap == null)
        {
            throw new("No RenderedFrame");
        }

        bitmap.Save(memoryStream);
        memoryStream.Position = 0;
        return new(null,
            new List<Target>
            {
                new("png", memoryStream)
            });
    }
}