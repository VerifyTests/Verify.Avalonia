class SelectableTextBlockConverter :
    WriteOnlyJsonConverter<SelectableTextBlock>
{
    public override void Write(VerifyJsonWriter writer, SelectableTextBlock value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TextBlockConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, SelectableTextBlock value)
    {
         writer.WriteMember(value, value.SelectionBrush, "SelectionBrush");
         writer.WriteMember(value, value.SelectionStart, "SelectionStart");
         writer.WriteMember(value, value.SelectionEnd, "SelectionEnd");
         writer.WriteMember(value, value.SelectedText, "SelectedText");
         writer.WriteMember(value, value.CanCopy, "CanCopy");
    }
}
