class VisualLayerManagerConverter :
    WriteOnlyJsonConverter<VisualLayerManager>
{
    public override void Write(VerifyJsonWriter writer, VisualLayerManager value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        DecoratorConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, VisualLayerManager value)
    {
         writer.WriteMember(value, value.IsPopup, "IsPopup");
         writer.WriteMember(value, value.AdornerLayer, "AdornerLayer");
         writer.WriteMember(value, value.ChromeOverlayLayer, "ChromeOverlayLayer");
         writer.WriteMember(value, value.OverlayLayer, "OverlayLayer");
         writer.WriteMember(value, value.LightDismissOverlayLayer, "LightDismissOverlayLayer");
    }
}
