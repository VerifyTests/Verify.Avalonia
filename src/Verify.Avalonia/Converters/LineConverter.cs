class LineConverter :
    WriteOnlyJsonConverter<Line>
{
    public override void Write(VerifyJsonWriter writer, Line value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ShapeConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Line value)
    {
         writer.WriteMember(value, value.StartPoint, "StartPoint");
         writer.WriteMember(value, value.EndPoint, "EndPoint");
    }
}
