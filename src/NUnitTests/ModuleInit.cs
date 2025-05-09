﻿public static class ModuleInit
{
    #region Enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageMagick.RegisterComparers(0.17);
        VerifyAvalonia.Initialize();
    }

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}