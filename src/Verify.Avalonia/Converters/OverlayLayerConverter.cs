class OverlayLayerConverter :
    WriteOnlyJsonConverter<OverlayLayer>
{
    public override void Write(VerifyJsonWriter writer, OverlayLayer value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        CanvasConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, OverlayLayer value)
    {
         writer.WriteMember(value, value.AvailableSize, "AvailableSize");
    }
}
