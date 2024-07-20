public static class ModuleInit
{
    [ModuleInitializer]
    public static void InitOther()
    {
        VerifyImageSharpCompare.Initialize();
        VerifierSettings.InitializePlugins();
    }
}