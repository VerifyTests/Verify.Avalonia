class ShapeConverter :
    WriteOnlyJsonConverter<Shape>
{
    public override void Write(VerifyJsonWriter writer, Shape value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Shape value)
    {
         writer.WriteMember(value, value.DefiningGeometry, "DefiningGeometry");
         writer.WriteMember(value, value.RenderedGeometry, "RenderedGeometry");
         writer.WriteMember(value, value.Fill, "Fill");
         writer.WriteMember(value, value.Stretch, "Stretch");
         writer.WriteMember(value, value.Stroke, "Stroke");
         writer.WriteMember(value, value.StrokeDashArray, "StrokeDashArray");
         writer.WriteMember(value, value.StrokeDashOffset, "StrokeDashOffset");
         writer.WriteMember(value, value.StrokeThickness, "StrokeThickness");
         writer.WriteMember(value, value.StrokeLineCap, "StrokeLineCap");
         writer.WriteMember(value, value.StrokeJoin, "StrokeJoin");
    }
}
