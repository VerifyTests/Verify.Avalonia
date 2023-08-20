class TopLevelConverter :
    WriteOnlyJsonConverter<TopLevel>
{
    public override void Write(VerifyJsonWriter writer, TopLevel value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TopLevel value)
    {
         writer.WriteMember(value, value.ClientSize, "ClientSize");
         writer.WriteMember(value, value.FrameSize, "FrameSize");
         writer.WriteMember(value, value.TransparencyLevelHint, "TransparencyLevelHint");
         writer.WriteMember(value, value.ActualTransparencyLevel, "ActualTransparencyLevel");
         writer.WriteMember(value, value.TransparencyBackgroundFallback, "TransparencyBackgroundFallback");
         writer.WriteMember(value, value.RequestedThemeVariant, "RequestedThemeVariant");
         writer.WriteMember(value, value.PlatformImpl, "PlatformImpl");
         writer.WriteMember(value, value.RendererDiagnostics, "RendererDiagnostics");
         writer.WriteMember(value, value.RenderScaling, "RenderScaling");
         writer.WriteMember(value, value.StorageProvider, "StorageProvider");
         writer.WriteMember(value, value.InsetsManager, "InsetsManager");
         writer.WriteMember(value, value.Clipboard, "Clipboard");
         writer.WriteMember(value, value.FocusManager, "FocusManager");
         writer.WriteMember(value, value.PlatformSettings, "PlatformSettings");
    }
}
