class TextBlockConverter :
    WriteOnlyJsonConverter<TextBlock>
{
    public override void Write(VerifyJsonWriter writer, TextBlock value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TextBlock value)
    {
         writer.WriteMember(value, value.TextLayout, "TextLayout");
         writer.WriteMember(value, value.Padding, "Padding");
         writer.WriteMember(value, value.Background, "Background");
         writer.WriteMember(value, value.Text, "Text");
         writer.WriteMember(value, value.FontFamily, "FontFamily");
         writer.WriteMember(value, value.FontSize, "FontSize");
         writer.WriteMember(value, value.FontStyle, "FontStyle");
         writer.WriteMember(value, value.FontWeight, "FontWeight");
         writer.WriteMember(value, value.FontStretch, "FontStretch");
         writer.WriteMember(value, value.Foreground, "Foreground");
         writer.WriteMember(value, value.LineHeight, "LineHeight");
         writer.WriteMember(value, value.LetterSpacing, "LetterSpacing");
         writer.WriteMember(value, value.MaxLines, "MaxLines");
         writer.WriteMember(value, value.TextWrapping, "TextWrapping");
         writer.WriteMember(value, value.TextTrimming, "TextTrimming");
         writer.WriteMember(value, value.TextAlignment, "TextAlignment");
         writer.WriteMember(value, value.TextDecorations, "TextDecorations");
         writer.WriteMember(value, value.Inlines, "Inlines");
         writer.WriteMember(value, value.BaselineOffset, "BaselineOffset");
    }
}
