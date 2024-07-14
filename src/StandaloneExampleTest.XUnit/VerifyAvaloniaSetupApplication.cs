[assembly: AvaloniaTestApplication(typeof(VerifyAvaloniaSetupApplication))]

public class VerifyAvaloniaSetupApplication : Application
{
    [ModuleInitializer]
    public static void Init() =>
        VerifyAvalonia.Initialize();

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
        this.Styles.Add(new FluentTheme());
}