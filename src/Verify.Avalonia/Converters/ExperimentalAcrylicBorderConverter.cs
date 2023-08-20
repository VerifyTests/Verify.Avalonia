class ExperimentalAcrylicBorderConverter :
    WriteOnlyJsonConverter<ExperimentalAcrylicBorder>
{
    public override void Write(VerifyJsonWriter writer, ExperimentalAcrylicBorder value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        DecoratorConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ExperimentalAcrylicBorder value)
    {
         writer.WriteMember(value, value.CornerRadius, "CornerRadius");
         writer.WriteMember(value, value.Material, "Material");
    }
}
