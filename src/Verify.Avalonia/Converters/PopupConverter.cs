class PopupConverter :
    WriteOnlyJsonConverter<Popup>
{
    public override void Write(VerifyJsonWriter writer, Popup value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Popup value)
    {
         writer.WriteMember(value, value.Host, "Host");
         writer.WriteMember(value, value.WindowManagerAddShadowHint, "WindowManagerAddShadowHint");
         writer.WriteMember(value, value.Child, "Child");
         writer.WriteMember(value, value.DependencyResolver, "DependencyResolver");
         writer.WriteMember(value, value.InheritsTransform, "InheritsTransform");
         writer.WriteMember(value, value.IsLightDismissEnabled, "IsLightDismissEnabled");
         writer.WriteMember(value, value.IsOpen, "IsOpen");
         writer.WriteMember(value, value.PlacementAnchor, "PlacementAnchor");
         writer.WriteMember(value, value.PlacementConstraintAdjustment, "PlacementConstraintAdjustment");
         writer.WriteMember(value, value.PlacementGravity, "PlacementGravity");
         writer.WriteMember(value, value.Placement, "Placement");
         writer.WriteMember(value, value.PlacementRect, "PlacementRect");
         writer.WriteMember(value, value.PlacementTarget, "PlacementTarget");
         writer.WriteMember(value, value.OverlayDismissEventPassThrough, "OverlayDismissEventPassThrough");
         writer.WriteMember(value, value.OverlayInputPassThroughElement, "OverlayInputPassThroughElement");
         writer.WriteMember(value, value.HorizontalOffset, "HorizontalOffset");
         writer.WriteMember(value, value.VerticalOffset, "VerticalOffset");
         writer.WriteMember(value, value.Topmost, "Topmost");
         writer.WriteMember(value, value.IsPointerOverPopup, "IsPointerOverPopup");
    }
}
