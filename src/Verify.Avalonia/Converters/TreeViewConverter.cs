class TreeViewConverter :
    WriteOnlyJsonConverter<TreeView>
{
    public override void Write(VerifyJsonWriter writer, TreeView value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TreeView value)
    {
         writer.WriteMember(value, value.ItemContainerGenerator, "ItemContainerGenerator");
         writer.WriteMember(value, value.AutoScrollToSelectedItem, "AutoScrollToSelectedItem");
         writer.WriteMember(value, value.SelectionMode, "SelectionMode");
         writer.WriteMember(value, value.SelectedItem, "SelectedItem");
         writer.WriteMember(value, value.SelectedItems, "SelectedItems");
    }
}
