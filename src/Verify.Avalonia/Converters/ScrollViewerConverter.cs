// <auto-generated />
class ScrollViewerConverter :
    WriteOnlyJsonConverter<ScrollViewer>
{
    public override void Write(VerifyJsonWriter writer, ScrollViewer value)
    {
        writer.WriteStartObject();
        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ScrollViewer value)
    {
         writer.WriteMember(value, value.BringIntoViewOnFocusChange, "BringIntoViewOnFocusChange");
         writer.WriteMember(value, value.Extent, "Extent");
         writer.WriteMember(value, value.Offset, "Offset");
         writer.WriteMember(value, value.Viewport, "Viewport");
         writer.WriteMember(value, value.LargeChange, "LargeChange");
         writer.WriteMember(value, value.SmallChange, "SmallChange");
         writer.WriteMember(value, value.HorizontalScrollBarVisibility, "HorizontalScrollBarVisibility");
         writer.WriteMember(value, value.VerticalScrollBarVisibility, "VerticalScrollBarVisibility");
         writer.WriteMember(value, value.CurrentAnchor, "CurrentAnchor");
         writer.WriteMember(value, value.ScrollBarMaximum, "ScrollBarMaximum");
         writer.WriteMember(value, value.IsExpanded, "IsExpanded");
         writer.WriteMember(value, value.HorizontalSnapPointsType, "HorizontalSnapPointsType");
         writer.WriteMember(value, value.VerticalSnapPointsType, "VerticalSnapPointsType");
         writer.WriteMember(value, value.HorizontalSnapPointsAlignment, "HorizontalSnapPointsAlignment");
         writer.WriteMember(value, value.VerticalSnapPointsAlignment, "VerticalSnapPointsAlignment");
         writer.WriteMember(value, value.AllowAutoHide, "AllowAutoHide");
         writer.WriteMember(value, value.IsScrollChainingEnabled, "IsScrollChainingEnabled");
         writer.WriteMember(value, value.IsScrollInertiaEnabled, "IsScrollInertiaEnabled");
    }
}