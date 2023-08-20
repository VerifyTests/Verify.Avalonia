class CalendarConverter :
    WriteOnlyJsonConverter<Calendar>
{
    public override void Write(VerifyJsonWriter writer, Calendar value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Calendar value)
    {
         writer.WriteMember(value, value.FirstDayOfWeek, "FirstDayOfWeek");
         writer.WriteMember(value, value.IsTodayHighlighted, "IsTodayHighlighted");
         writer.WriteMember(value, value.HeaderBackground, "HeaderBackground");
         writer.WriteMember(value, value.DisplayMode, "DisplayMode");
         writer.WriteMember(value, value.SelectionMode, "SelectionMode");
         writer.WriteMember(value, value.SelectedDate, "SelectedDate");
         writer.WriteMember(value, value.SelectedDates, "SelectedDates");
         writer.WriteMember(value, value.DisplayDate, "DisplayDate");
         writer.WriteMember(value, value.DisplayDateStart, "DisplayDateStart");
         writer.WriteMember(value, value.BlackoutDates, "BlackoutDates");
         writer.WriteMember(value, value.DisplayDateEnd, "DisplayDateEnd");
    }
}
