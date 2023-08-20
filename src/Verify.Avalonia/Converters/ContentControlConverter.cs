class ContentControlConverter :
    WriteOnlyJsonConverter<ContentControl>
{
    public override void Write(VerifyJsonWriter writer, ContentControl value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ContentControl value)
    {
         writer.WriteMember(value, value.Content, "Content");
         writer.WriteMember(value, value.ContentTemplate, "ContentTemplate");
         writer.WriteMember(value, value.Presenter, "Presenter");
         writer.WriteMember(value, value.HorizontalContentAlignment, "HorizontalContentAlignment");
         writer.WriteMember(value, value.VerticalContentAlignment, "VerticalContentAlignment");
    }
}
