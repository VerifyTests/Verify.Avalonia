public static class ModuleInit
{
    [ModuleInitializer]
    public static void InitOther()
    {
        VerifyImageMagick.Initialize();
        VerifierSettings.InitializePlugins();
    }
}