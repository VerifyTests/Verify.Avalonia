class RelativePanelConverter :
    WriteOnlyJsonConverter<RelativePanel>
{
    public override void Write(VerifyJsonWriter writer, RelativePanel value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        PanelConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, RelativePanel value)
    {
    }
}
