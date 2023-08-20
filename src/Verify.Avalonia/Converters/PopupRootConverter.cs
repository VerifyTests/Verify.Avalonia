class PopupRootConverter :
    WriteOnlyJsonConverter<PopupRoot>
{
    public override void Write(VerifyJsonWriter writer, PopupRoot value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        WindowBaseConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, PopupRoot value)
    {
         writer.WriteMember(value, value.PlatformImpl, "PlatformImpl");
         writer.WriteMember(value, value.Transform, "Transform");
         writer.WriteMember(value, value.ParentTopLevel, "ParentTopLevel");
    }
}
