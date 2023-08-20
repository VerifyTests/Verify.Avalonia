class UniformGridConverter :
    WriteOnlyJsonConverter<UniformGrid>
{
    public override void Write(VerifyJsonWriter writer, UniformGrid value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        PanelConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, UniformGrid value)
    {
         writer.WriteMember(value, value.Rows, "Rows");
         writer.WriteMember(value, value.Columns, "Columns");
         writer.WriteMember(value, value.FirstColumn, "FirstColumn");
    }
}
