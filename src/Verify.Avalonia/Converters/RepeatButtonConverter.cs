class RepeatButtonConverter :
    WriteOnlyJsonConverter<RepeatButton>
{
    public override void Write(VerifyJsonWriter writer, RepeatButton value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, RepeatButton value)
    {
         writer.WriteMember(value, value.Interval, "Interval");
         writer.WriteMember(value, value.Delay, "Delay");
    }
}
