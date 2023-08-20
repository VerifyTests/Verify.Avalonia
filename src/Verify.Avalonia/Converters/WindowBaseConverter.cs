class WindowBaseConverter :
    WriteOnlyJsonConverter<WindowBase>
{
    public override void Write(VerifyJsonWriter writer, WindowBase value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TopLevelConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, WindowBase value)
    {
         writer.WriteMember(value, value.PlatformImpl, "PlatformImpl");
         writer.WriteMember(value, value.IsActive, "IsActive");
         writer.WriteMember(value, value.Screens, "Screens");
         writer.WriteMember(value, value.Owner, "Owner");
         writer.WriteMember(value, value.Topmost, "Topmost");
         writer.WriteMember(value, value.DesktopScaling, "DesktopScaling");
    }
}
