public static class ModuleInit
{
    [ModuleInitializer]
    public static void InitOther()
    {
        VerifyImageMagick.RegisterComparers(.097);
        VerifierSettings.InitializePlugins();
    }
}