// <auto-generated />
class ScrollBarConverter :
    WriteOnlyJsonConverter<ScrollBar>
{
    public override void Write(VerifyJsonWriter writer, ScrollBar value)
    {
        writer.WriteStartObject();
        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        WriteMembers(writer, value);
        RangeBaseConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ScrollBar value)
    {
         writer.WriteMember(value, value.ViewportSize, "ViewportSize");
         writer.WriteMember(value, value.Visibility, "Visibility");
         writer.WriteMember(value, value.Orientation, "Orientation");
         writer.WriteMember(value, value.IsExpanded, "IsExpanded");
         writer.WriteMember(value, value.AllowAutoHide, "AllowAutoHide");
         writer.WriteMember(value, value.HideDelay, "HideDelay");
         writer.WriteMember(value, value.ShowDelay, "ShowDelay");
    }
}