class ThumbConverter :
    WriteOnlyJsonConverter<Thumb>
{
    public override void Write(VerifyJsonWriter writer, Thumb value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Thumb value)
    {
    }
}
