class DecoratorConverter :
    WriteOnlyJsonConverter<Decorator>
{
    public override void Write(VerifyJsonWriter writer, Decorator value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Decorator value)
    {
         writer.WriteMember(value, value.Child, "Child");
         writer.WriteMember(value, value.Padding, "Padding");
    }
}
