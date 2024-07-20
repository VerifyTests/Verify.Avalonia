public static class ModuleInit
{
    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}