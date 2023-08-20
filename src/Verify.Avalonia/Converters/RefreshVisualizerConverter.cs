class RefreshVisualizerConverter :
    WriteOnlyJsonConverter<RefreshVisualizer>
{
    public override void Write(VerifyJsonWriter writer, RefreshVisualizer value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, RefreshVisualizer value)
    {
         writer.WriteMember(value, value.Orientation, "Orientation");
    }
}
