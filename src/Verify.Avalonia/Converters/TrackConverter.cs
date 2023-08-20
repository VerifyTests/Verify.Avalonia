class TrackConverter :
    WriteOnlyJsonConverter<Track>
{
    public override void Write(VerifyJsonWriter writer, Track value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Track value)
    {
         writer.WriteMember(value, value.Minimum, "Minimum");
         writer.WriteMember(value, value.Maximum, "Maximum");
         writer.WriteMember(value, value.Value, "Value");
         writer.WriteMember(value, value.ViewportSize, "ViewportSize");
         writer.WriteMember(value, value.Orientation, "Orientation");
         writer.WriteMember(value, value.Thumb, "Thumb");
         writer.WriteMember(value, value.IncreaseButton, "IncreaseButton");
         writer.WriteMember(value, value.DecreaseButton, "DecreaseButton");
         writer.WriteMember(value, value.IsDirectionReversed, "IsDirectionReversed");
         writer.WriteMember(value, value.IgnoreThumbDrag, "IgnoreThumbDrag");
    }
}
