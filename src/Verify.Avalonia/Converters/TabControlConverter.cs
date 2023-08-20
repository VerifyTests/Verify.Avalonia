class TabControlConverter :
    WriteOnlyJsonConverter<TabControl>
{
    public override void Write(VerifyJsonWriter writer, TabControl value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        SelectingItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TabControl value)
    {
         writer.WriteMember(value, value.HorizontalContentAlignment, "HorizontalContentAlignment");
         writer.WriteMember(value, value.VerticalContentAlignment, "VerticalContentAlignment");
         writer.WriteMember(value, value.TabStripPlacement, "TabStripPlacement");
         writer.WriteMember(value, value.ContentTemplate, "ContentTemplate");
         writer.WriteMember(value, value.SelectedContent, "SelectedContent");
         writer.WriteMember(value, value.SelectedContentTemplate, "SelectedContentTemplate");
    }
}
