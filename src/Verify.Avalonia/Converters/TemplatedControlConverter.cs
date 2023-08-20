class TemplatedControlConverter :
    WriteOnlyJsonConverter<TemplatedControl>
{
    public override void Write(VerifyJsonWriter writer, TemplatedControl value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TemplatedControl value)
    {
         writer.WriteMember(value, value.Background, "Background");
         writer.WriteMember(value, value.BorderBrush, "BorderBrush");
         writer.WriteMember(value, value.BorderThickness, "BorderThickness");
         writer.WriteMember(value, value.CornerRadius, "CornerRadius");
         writer.WriteMember(value, value.FontFamily, "FontFamily");
         writer.WriteMember(value, value.FontSize, "FontSize");
         writer.WriteMember(value, value.FontStyle, "FontStyle");
         writer.WriteMember(value, value.FontWeight, "FontWeight");
         writer.WriteMember(value, value.FontStretch, "FontStretch");
         writer.WriteMember(value, value.Foreground, "Foreground");
         writer.WriteMember(value, value.Padding, "Padding");
         writer.WriteMember(value, value.Template, "Template");
    }
}
