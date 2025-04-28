public static class ModuleInit
{
    #region EnableIncludeThemeVariant

    [ModuleInitializer]
    public static void Init()
    {
        VerifyAvalonia.IncludeThemeVariant();
        VerifierSettings.InitializePlugins();
    }

    #endregion
}