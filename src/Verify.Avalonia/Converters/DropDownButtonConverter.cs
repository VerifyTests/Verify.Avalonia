// <auto-generated />
class DropDownButtonConverter :
    WriteOnlyJsonConverter<DropDownButton>
{
    public override void Write(VerifyJsonWriter writer, DropDownButton value)
    {
        writer.WriteStartObject();
        VerifyAvalonia.WriteGeneratedMembers(writer, value);
        WriteMembers(writer, value);
        ButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, DropDownButton value)
    {
    }
}