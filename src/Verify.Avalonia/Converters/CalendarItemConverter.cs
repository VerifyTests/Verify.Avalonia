// <auto-generated />
class CalendarItemConverter :
    WriteOnlyJsonConverter<CalendarItem>
{
    public override void Write(VerifyJsonWriter writer, CalendarItem value)
    {
        writer.WriteStartObject();
        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, CalendarItem value)
    {
         writer.WriteMember(value, value.HeaderBackground, "HeaderBackground");
         writer.WriteMember(value, value.DayTitleTemplate, "DayTitleTemplate");
    }
}