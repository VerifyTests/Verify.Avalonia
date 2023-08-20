class WrapPanelConverter :
    WriteOnlyJsonConverter<WrapPanel>
{
    public override void Write(VerifyJsonWriter writer, WrapPanel value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        PanelConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, WrapPanel value)
    {
         writer.WriteMember(value, value.Orientation, "Orientation");
         writer.WriteMember(value, value.ItemWidth, "ItemWidth");
         writer.WriteMember(value, value.ItemHeight, "ItemHeight");
    }
}
