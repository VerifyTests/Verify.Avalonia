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
        VerifierSettings.RegisterFileConverter<Window>(WindowToImage);
        VerifierSettings.RegisterFileConverter<TopLevel>(TopLevelToImage);
        VerifierSettings.RegisterFileConverter<UserControl>(ControlToImage);
        AddConverters();
    }

    static ConversionResult ControlToImage(UserControl control, IReadOnlyDictionary<string, object> context)
    {
        var window = new Window
        {
            Content = control
        };
        window.Show();
        return new(
            control,
            [new("png", window.ToImage())],
            () =>
            {
                window.Close();
                return Task.CompletedTask;
            });
    }
    static ConversionResult WindowToImage(Window window, IReadOnlyDictionary<string, object> context)
    {
        window.Show();
        return new(
            window,
            [new("png", window.ToImage())],
            () =>
            {
                window.Close();
                return Task.CompletedTask;
            });
    }

    static ConversionResult TopLevelToImage(TopLevel topLevel, IReadOnlyDictionary<string, object> context) =>
        new(topLevel, [new("png", topLevel.ToImage())]);
}