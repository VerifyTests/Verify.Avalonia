class SelectingItemsControlConverter :
    WriteOnlyJsonConverter<SelectingItemsControl>
{
    public override void Write(VerifyJsonWriter writer, SelectingItemsControl value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, SelectingItemsControl value)
    {
         writer.WriteMember(value, value.AutoScrollToSelectedItem, "AutoScrollToSelectedItem");
         writer.WriteMember(value, value.SelectedIndex, "SelectedIndex");
         writer.WriteMember(value, value.SelectedItem, "SelectedItem");
         writer.WriteMember(value, value.SelectedValueBinding, "SelectedValueBinding");
         writer.WriteMember(value, value.SelectedValue, "SelectedValue");
         writer.WriteMember(value, value.IsTextSearchEnabled, "IsTextSearchEnabled");
         writer.WriteMember(value, value.WrapSelection, "WrapSelection");
    }
}
