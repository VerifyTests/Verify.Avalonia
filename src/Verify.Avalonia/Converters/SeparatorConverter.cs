class SeparatorConverter :
    WriteOnlyJsonConverter<Separator>
{
    public override void Write(VerifyJsonWriter writer, Separator value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Separator value)
    {
    }
}
