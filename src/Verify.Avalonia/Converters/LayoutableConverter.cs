// <auto-generated />
class LayoutableConverter :
    WriteOnlyJsonConverter<Layoutable>
{
    public override void Write(VerifyJsonWriter writer, Layoutable value)
    {
        writer.WriteStartObject();
        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        WriteMembers(writer, value);
        VisualConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Layoutable value)
    {
         writer.WriteMember(value, value.Width, "Width");
         writer.WriteMember(value, value.Height, "Height");
         writer.WriteMember(value, value.MinWidth, "MinWidth");
         writer.WriteMember(value, value.MaxWidth, "MaxWidth");
         writer.WriteMember(value, value.MinHeight, "MinHeight");
         writer.WriteMember(value, value.MaxHeight, "MaxHeight");
         writer.WriteMember(value, value.Margin, "Margin");
         writer.WriteMember(value, value.HorizontalAlignment, "HorizontalAlignment");
         writer.WriteMember(value, value.VerticalAlignment, "VerticalAlignment");
         writer.WriteMember(value, value.DesiredSize, "DesiredSize");
         writer.WriteMember(value, value.IsMeasureValid, "IsMeasureValid");
         writer.WriteMember(value, value.IsArrangeValid, "IsArrangeValid");
         writer.WriteMember(value, value.UseLayoutRounding, "UseLayoutRounding");
    }
}