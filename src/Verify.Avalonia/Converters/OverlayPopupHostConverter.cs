class OverlayPopupHostConverter :
    WriteOnlyJsonConverter<OverlayPopupHost>
{
    public override void Write(VerifyJsonWriter writer, OverlayPopupHost value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, OverlayPopupHost value)
    {
         writer.WriteMember(value, value.HostedVisualTreeRoot, "HostedVisualTreeRoot");
         writer.WriteMember(value, value.Transform, "Transform");
    }
}
