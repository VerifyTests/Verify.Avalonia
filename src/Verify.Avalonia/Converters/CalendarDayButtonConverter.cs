class CalendarDayButtonConverter :
    WriteOnlyJsonConverter<CalendarDayButton>
{
    public override void Write(VerifyJsonWriter writer, CalendarDayButton value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, CalendarDayButton value)
    {
    }
}
