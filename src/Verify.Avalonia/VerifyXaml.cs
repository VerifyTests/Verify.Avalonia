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
      //  VerifierSettings.RegisterFileConverter<Window>(WindowToImage);
    }

    // static ConversionResult WindowToImage(Window window, IReadOnlyDictionary<string, object> context)
    // {
    //     var pngStream = WpfUtils.ScreenCapture(window);
    //     return new(null,
    //         new List<Target>
    //         {
    //             new("xml", window.ToXamlString()),
    //             new("png", pngStream)
    //         });
    // }
}