class HeaderedSelectingItemsControlConverter :
    WriteOnlyJsonConverter<HeaderedSelectingItemsControl>
{
    public override void Write(VerifyJsonWriter writer, HeaderedSelectingItemsControl value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        SelectingItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, HeaderedSelectingItemsControl value)
    {
         writer.WriteMember(value, value.Header, "Header");
         writer.WriteMember(value, value.HeaderTemplate, "HeaderTemplate");
         writer.WriteMember(value, value.HeaderPresenter, "HeaderPresenter");
    }
}
