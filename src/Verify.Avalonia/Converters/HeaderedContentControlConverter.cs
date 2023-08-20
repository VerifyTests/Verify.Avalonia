class HeaderedContentControlConverter :
    WriteOnlyJsonConverter<HeaderedContentControl>
{
    public override void Write(VerifyJsonWriter writer, HeaderedContentControl value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, HeaderedContentControl value)
    {
         writer.WriteMember(value, value.Header, "Header");
         writer.WriteMember(value, value.HeaderPresenter, "HeaderPresenter");
         writer.WriteMember(value, value.HeaderTemplate, "HeaderTemplate");
    }
}
