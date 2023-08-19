using Avalonia;
using Avalonia.Headless;
using TestableApp;

[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

public class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>()
        .UseSkia()
        .UseHeadless(new()
        {
            UseHeadlessDrawing = false
        });
}