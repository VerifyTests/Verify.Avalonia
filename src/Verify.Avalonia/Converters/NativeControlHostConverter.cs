class NativeControlHostConverter :
    WriteOnlyJsonConverter<NativeControlHost>
{
    public override void Write(VerifyJsonWriter writer, NativeControlHost value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, NativeControlHost value)
    {
    }
}
