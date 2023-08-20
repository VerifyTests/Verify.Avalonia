class CalendarDatePickerConverter :
    WriteOnlyJsonConverter<CalendarDatePicker>
{
    public override void Write(VerifyJsonWriter writer, CalendarDatePicker value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        TemplatedControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, CalendarDatePicker value)
    {
         writer.WriteMember(value, value.BlackoutDates, "BlackoutDates");
         writer.WriteMember(value, value.DisplayDate, "DisplayDate");
         writer.WriteMember(value, value.DisplayDateStart, "DisplayDateStart");
         writer.WriteMember(value, value.DisplayDateEnd, "DisplayDateEnd");
         writer.WriteMember(value, value.FirstDayOfWeek, "FirstDayOfWeek");
         writer.WriteMember(value, value.IsDropDownOpen, "IsDropDownOpen");
         writer.WriteMember(value, value.IsTodayHighlighted, "IsTodayHighlighted");
         writer.WriteMember(value, value.SelectedDate, "SelectedDate");
         writer.WriteMember(value, value.SelectedDateFormat, "SelectedDateFormat");
         writer.WriteMember(value, value.CustomDateFormatString, "CustomDateFormatString");
         writer.WriteMember(value, value.Text, "Text");
         writer.WriteMember(value, value.Watermark, "Watermark");
         writer.WriteMember(value, value.UseFloatingWatermark, "UseFloatingWatermark");
         writer.WriteMember(value, value.HorizontalContentAlignment, "HorizontalContentAlignment");
         writer.WriteMember(value, value.VerticalContentAlignment, "VerticalContentAlignment");
    }
}
