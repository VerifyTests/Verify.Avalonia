public static class ModuleInit
{
    [ModuleInitializer]
    public static void InitOther()
    {
        VerifyImageMagick.RegisterComparers(0.17);
        VerifierSettings.InitializePlugins();
    }
}