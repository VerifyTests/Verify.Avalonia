class AdornerLayerConverter :
    WriteOnlyJsonConverter<AdornerLayer>
{
    public override void Write(VerifyJsonWriter writer, AdornerLayer value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        CanvasConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, AdornerLayer value)
    {
         writer.WriteMember(value, value.DefaultFocusAdorner, "DefaultFocusAdorner");
    }
}
