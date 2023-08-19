using System.Runtime.CompilerServices;
using VerifyTests;

public static class ModuleInit
{
    #region Enable

    [ModuleInitializer]
    public static void Init() =>
        VerifyAvalonia.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}