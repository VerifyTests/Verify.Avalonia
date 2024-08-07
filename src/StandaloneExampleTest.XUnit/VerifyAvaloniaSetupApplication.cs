[assembly: AvaloniaTestApplication(typeof(VerifyAvaloniaSetupApplication))]

public class VerifyAvaloniaSetupApplication : Application
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageMagick.RegisterComparers(.24);
        VerifierSettings.InitializePlugins();
    }

    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder
            .Configure<VerifyAvaloniaSetupApplication>()
            .UseSkia()
            .UseHeadless(
                new()
                {
                    UseHeadlessDrawing = false
                });

    public VerifyAvaloniaSetupApplication() =>
        Styles.Add(new FluentTheme());
}