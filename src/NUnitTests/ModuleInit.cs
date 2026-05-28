public static class ModuleInit
{
    #region Enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifierSettings.UseSsimForPng();
        VerifyAvalonia.Initialize();
    }

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}
