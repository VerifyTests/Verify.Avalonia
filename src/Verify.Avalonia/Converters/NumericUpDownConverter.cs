class NumericUpDownConverter :
    WriteOnlyJsonConverter<NumericUpDown>
{
    public override void Write(VerifyJsonWriter writer, NumericUpDown value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, NumericUpDown value)
    {
         writer.WriteMember(value, value.AllowSpin, "AllowSpin");
         writer.WriteMember(value, value.ButtonSpinnerLocation, "ButtonSpinnerLocation");
         writer.WriteMember(value, value.ShowButtonSpinner, "ShowButtonSpinner");
         writer.WriteMember(value, value.ClipValueToMinMax, "ClipValueToMinMax");
         writer.WriteMember(value, value.NumberFormat, "NumberFormat");
         writer.WriteMember(value, value.FormatString, "FormatString");
         writer.WriteMember(value, value.Increment, "Increment");
         writer.WriteMember(value, value.IsReadOnly, "IsReadOnly");
         writer.WriteMember(value, value.Maximum, "Maximum");
         writer.WriteMember(value, value.Minimum, "Minimum");
         writer.WriteMember(value, value.ParsingNumberStyle, "ParsingNumberStyle");
         writer.WriteMember(value, value.Text, "Text");
         writer.WriteMember(value, value.TextConverter, "TextConverter");
         writer.WriteMember(value, value.Value, "Value");
         writer.WriteMember(value, value.Watermark, "Watermark");
         writer.WriteMember(value, value.HorizontalContentAlignment, "HorizontalContentAlignment");
         writer.WriteMember(value, value.VerticalContentAlignment, "VerticalContentAlignment");
         writer.WriteMember(value, value.TextAlignment, "TextAlignment");
    }
}
