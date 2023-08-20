class ProgressBarConverter :
    WriteOnlyJsonConverter<ProgressBar>
{
    public override void Write(VerifyJsonWriter writer, ProgressBar value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        RangeBaseConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ProgressBar value)
    {
         writer.WriteMember(value, value.Percentage, "Percentage");
         writer.WriteMember(value, value.TemplateSettings, "TemplateSettings");
         writer.WriteMember(value, value.IsIndeterminate, "IsIndeterminate");
         writer.WriteMember(value, value.ShowProgressText, "ShowProgressText");
         writer.WriteMember(value, value.ProgressTextFormat, "ProgressTextFormat");
         writer.WriteMember(value, value.Orientation, "Orientation");
    }
}
