// <auto-generated />
class CheckBoxConverter :
    WriteOnlyJsonConverter<CheckBox>
{
    public override void Write(VerifyJsonWriter writer, CheckBox value)
    {
        writer.WriteStartObject();
        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        WriteMembers(writer, value);
        ToggleButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, CheckBox value)
    {
    }
}