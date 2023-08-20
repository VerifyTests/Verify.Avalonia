class TabStripConverter :
    WriteOnlyJsonConverter<TabStrip>
{
    public override void Write(VerifyJsonWriter writer, TabStrip value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        SelectingItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TabStrip value)
    {
    }
}
