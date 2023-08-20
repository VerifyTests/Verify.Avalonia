class RectangleConverter :
    WriteOnlyJsonConverter<Rectangle>
{
    public override void Write(VerifyJsonWriter writer, Rectangle value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ShapeConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Rectangle value)
    {
         writer.WriteMember(value, value.RadiusX, "RadiusX");
         writer.WriteMember(value, value.RadiusY, "RadiusY");
    }
}
