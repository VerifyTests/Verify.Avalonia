public static class ModuleInit
{
    [ModuleInitializer]
    public static void Init() =>
        VerifyAvalonia.Initialize();

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}