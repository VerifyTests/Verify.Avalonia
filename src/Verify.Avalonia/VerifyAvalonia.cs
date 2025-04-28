using Avalonia.Styling;

namespace VerifyTests;

public static partial class VerifyAvalonia
{
    public static bool Initialized { get; private set; }

    public static void IncludeThemeVariant()
    {
        InnerVerifier.ThrowIfVerifyHasBeenRun();
        ShouldIncludeThemeVariant = true;
    }

    internal static bool ShouldIncludeThemeVariant;

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
            Content = control,
            SizeToContent = SizeToContent.WidthAndHeight,
        };
        window.Show();
        return new(
            control,
            BuildWindowTargets(window),
            Cleanup(window));
    }


    static Func<Task> Cleanup(Window window) =>
        () =>
        {
            window.Close();
            return Task.CompletedTask;
        };

    static ConversionResult WindowToImage(Window window, IReadOnlyDictionary<string, object> context)
    {
        window.Show();
        return new(
            window,
            BuildWindowTargets(window),
            Cleanup(window));
    }

    static IEnumerable<Target> BuildWindowTargets(TopLevel window)
    {
        if (ShouldIncludeThemeVariant)
        {
            var application = Application.Current!;
            application.RequestedThemeVariant = ThemeVariant.Light;
            var light = new Target("png", window.ToImage(), "light");
            application.RequestedThemeVariant = ThemeVariant.Dark;
            var dark = new Target("png", window.ToImage(), "dark");
            return [light, dark];
        }

        return [new("png", window.ToImage())];
    }

    static ConversionResult TopLevelToImage(TopLevel topLevel, IReadOnlyDictionary<string, object> context) =>
        new(topLevel, BuildWindowTargets(topLevel));
}