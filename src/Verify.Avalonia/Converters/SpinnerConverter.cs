class SpinnerConverter :
    WriteOnlyJsonConverter<Spinner>
{
    public override void Write(VerifyJsonWriter writer, Spinner value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Spinner value)
    {
         writer.WriteMember(value, value.ValidSpinDirection, "ValidSpinDirection");
    }
}
