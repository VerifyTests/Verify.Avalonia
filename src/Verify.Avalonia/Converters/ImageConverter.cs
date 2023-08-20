class ImageConverter :
    WriteOnlyJsonConverter<Image>
{
    public override void Write(VerifyJsonWriter writer, Image value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Image value)
    {
         writer.WriteMember(value, value.Source, "Source");
         writer.WriteMember(value, value.Stretch, "Stretch");
         writer.WriteMember(value, value.StretchDirection, "StretchDirection");
    }
}
