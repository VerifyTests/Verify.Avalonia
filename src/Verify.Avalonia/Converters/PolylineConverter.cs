class PolylineConverter :
    WriteOnlyJsonConverter<Polyline>
{
    public override void Write(VerifyJsonWriter writer, Polyline value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ShapeConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Polyline value)
    {
         writer.WriteMember(value, value.Points, "Points");
    }
}
