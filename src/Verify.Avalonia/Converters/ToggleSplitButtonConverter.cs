class ToggleSplitButtonConverter :
    WriteOnlyJsonConverter<ToggleSplitButton>
{
    public override void Write(VerifyJsonWriter writer, ToggleSplitButton value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        SplitButtonConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ToggleSplitButton value)
    {
         writer.WriteMember(value, value.IsChecked, "IsChecked");
    }
}
