class EmbeddableControlRootConverter :
    WriteOnlyJsonConverter<EmbeddableControlRoot>
{
    public override void Write(VerifyJsonWriter writer, EmbeddableControlRoot value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TopLevelConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, EmbeddableControlRoot value)
    {
    }
}
