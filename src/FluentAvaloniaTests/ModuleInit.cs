using FluentAvalonia.UI.Controls;

public static class ModuleInit
{
    [ModuleInitializer]
    public static void Init()
    {
        // FluentAvalonia
        VerifyAvalonia.AddAvaloniaConvertersForAssemblyOfType<NavigationView>();
        VerifierSettings.InitializePlugins();
    }
}