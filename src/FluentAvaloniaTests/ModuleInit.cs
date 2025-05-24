using FluentAvalonia.UI.Controls;

public static class ModuleInit
{
    #region InitAddAvaloniaConvertersForAssembly

    [ModuleInitializer]
    public static void Init()
    {
        // FluentAvalonia
        VerifyAvalonia.AddAvaloniaConvertersForAssemblyOfType<NavigationView>();
        VerifyImageMagick.RegisterComparers(0.17);
        VerifierSettings.InitializePlugins();
    }

    #endregion
}