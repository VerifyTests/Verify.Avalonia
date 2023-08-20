class ScrollContentPresenterConverter :
    WriteOnlyJsonConverter<ScrollContentPresenter>
{
    public override void Write(VerifyJsonWriter writer, ScrollContentPresenter value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentPresenterConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ScrollContentPresenter value)
    {
         writer.WriteMember(value, value.CanHorizontallyScroll, "CanHorizontallyScroll");
         writer.WriteMember(value, value.CanVerticallyScroll, "CanVerticallyScroll");
         writer.WriteMember(value, value.Extent, "Extent");
         writer.WriteMember(value, value.Offset, "Offset");
         writer.WriteMember(value, value.Viewport, "Viewport");
         writer.WriteMember(value, value.HorizontalSnapPointsType, "HorizontalSnapPointsType");
         writer.WriteMember(value, value.VerticalSnapPointsType, "VerticalSnapPointsType");
         writer.WriteMember(value, value.HorizontalSnapPointsAlignment, "HorizontalSnapPointsAlignment");
         writer.WriteMember(value, value.VerticalSnapPointsAlignment, "VerticalSnapPointsAlignment");
         writer.WriteMember(value, value.IsScrollChainingEnabled, "IsScrollChainingEnabled");
    }
}
