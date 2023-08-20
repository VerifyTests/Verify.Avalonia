class PolygonConverter :
    WriteOnlyJsonConverter<Polygon>
{
    public override void Write(VerifyJsonWriter writer, Polygon value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ShapeConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Polygon value)
    {
         writer.WriteMember(value, value.Points, "Points");
    }
}
