class ComboBoxConverter :
    WriteOnlyJsonConverter<ComboBox>
{
    public override void Write(VerifyJsonWriter writer, ComboBox value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        SelectingItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ComboBox value)
    {
         writer.WriteMember(value, value.IsDropDownOpen, "IsDropDownOpen");
         writer.WriteMember(value, value.MaxDropDownHeight, "MaxDropDownHeight");
         writer.WriteMember(value, value.SelectionBoxItem, "SelectionBoxItem");
         writer.WriteMember(value, value.PlaceholderText, "PlaceholderText");
         writer.WriteMember(value, value.PlaceholderForeground, "PlaceholderForeground");
         writer.WriteMember(value, value.HorizontalContentAlignment, "HorizontalContentAlignment");
         writer.WriteMember(value, value.VerticalContentAlignment, "VerticalContentAlignment");
    }
}
