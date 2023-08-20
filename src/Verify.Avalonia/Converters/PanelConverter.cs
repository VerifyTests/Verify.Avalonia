class PanelConverter :
    WriteOnlyJsonConverter<Panel>
{
    public override void Write(VerifyJsonWriter writer, Panel value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Panel value)
    {
         writer.WriteMember(value, value.Children, "Children");
         writer.WriteMember(value, value.Background, "Background");
         writer.WriteMember(value, value.IsItemsHost, "IsItemsHost");
    }
}
