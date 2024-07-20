public static class ModuleInit
{
    #region Enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageSharpCompare.RegisterComparers(threshold: 0);
        VerifyAvalonia.Initialize();
    }

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}