class IconElementConverter :
    WriteOnlyJsonConverter<IconElement>
{
    public override void Write(VerifyJsonWriter writer, IconElement value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, IconElement value)
    {
    }
}
