class TextBoxConverter :
    WriteOnlyJsonConverter<TextBox>
{
    public override void Write(VerifyJsonWriter writer, TextBox value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TextBox value)
    {
         writer.WriteMember(value, value.AcceptsReturn, "AcceptsReturn");
         writer.WriteMember(value, value.AcceptsTab, "AcceptsTab");
         writer.WriteMember(value, value.CaretIndex, "CaretIndex");
         writer.WriteMember(value, value.IsReadOnly, "IsReadOnly");
         writer.WriteMember(value, value.PasswordChar, "PasswordChar");
         writer.WriteMember(value, value.SelectionBrush, "SelectionBrush");
         writer.WriteMember(value, value.SelectionForegroundBrush, "SelectionForegroundBrush");
         writer.WriteMember(value, value.CaretBrush, "CaretBrush");
         writer.WriteMember(value, value.SelectionStart, "SelectionStart");
         writer.WriteMember(value, value.SelectionEnd, "SelectionEnd");
         writer.WriteMember(value, value.MaxLength, "MaxLength");
         writer.WriteMember(value, value.MaxLines, "MaxLines");
         writer.WriteMember(value, value.LetterSpacing, "LetterSpacing");
         writer.WriteMember(value, value.LineHeight, "LineHeight");
         writer.WriteMember(value, value.Text, "Text");
         writer.WriteMember(value, value.SelectedText, "SelectedText");
         writer.WriteMember(value, value.HorizontalContentAlignment, "HorizontalContentAlignment");
         writer.WriteMember(value, value.VerticalContentAlignment, "VerticalContentAlignment");
         writer.WriteMember(value, value.TextAlignment, "TextAlignment");
         writer.WriteMember(value, value.Watermark, "Watermark");
         writer.WriteMember(value, value.UseFloatingWatermark, "UseFloatingWatermark");
         writer.WriteMember(value, value.InnerLeftContent, "InnerLeftContent");
         writer.WriteMember(value, value.InnerRightContent, "InnerRightContent");
         writer.WriteMember(value, value.RevealPassword, "RevealPassword");
         writer.WriteMember(value, value.TextWrapping, "TextWrapping");
         writer.WriteMember(value, value.NewLine, "NewLine");
         writer.WriteMember(value, value.CanCut, "CanCut");
         writer.WriteMember(value, value.CanCopy, "CanCopy");
         writer.WriteMember(value, value.CanPaste, "CanPaste");
         writer.WriteMember(value, value.IsUndoEnabled, "IsUndoEnabled");
         writer.WriteMember(value, value.UndoLimit, "UndoLimit");
         writer.WriteMember(value, value.CanUndo, "CanUndo");
         writer.WriteMember(value, value.CanRedo, "CanRedo");
    }
}
