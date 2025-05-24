[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

public static class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<App>()
            .UseSkia()
            .UseHeadless(new () { UseHeadlessDrawing = false })
            .AfterSetup(builder =>
            {
                if (builder.Instance is null)
                    throw new ("Instance is null");
                var theme = new FluentAvaloniaTheme
                {
                    PreferSystemTheme = false,
                    PreferUserAccentColor = false
                };
                builder.Instance.Styles.Add(theme);
            });
}