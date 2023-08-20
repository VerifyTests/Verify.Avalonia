class TimePickerConverter :
    WriteOnlyJsonConverter<TimePicker>
{
    public override void Write(VerifyJsonWriter writer, TimePicker value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, TimePicker value)
    {
         writer.WriteMember(value, value.MinuteIncrement, "MinuteIncrement");
         writer.WriteMember(value, value.ClockIdentifier, "ClockIdentifier");
         writer.WriteMember(value, value.SelectedTime, "SelectedTime");
    }
}
