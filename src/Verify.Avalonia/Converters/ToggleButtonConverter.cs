class ToggleButtonConverter :
    WriteOnlyJsonConverter<ToggleButton>
{
    public override void Write(VerifyJsonWriter writer, ToggleButton value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ToggleButton value)
    {
         writer.WriteMember(value, value.IsChecked, "IsChecked");
         writer.WriteMember(value, value.IsThreeState, "IsThreeState");
    }
}
