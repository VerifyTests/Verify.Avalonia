class CalendarButtonConverter :
    WriteOnlyJsonConverter<CalendarButton>
{
    public override void Write(VerifyJsonWriter writer, CalendarButton value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, CalendarButton value)
    {
    }
}
