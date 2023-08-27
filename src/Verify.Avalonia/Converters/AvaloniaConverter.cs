class AvaloniaConverter<T> :
    WriteOnlyJsonConverter<T>
    where T : AvaloniaObject
{
    static AvaloniaProperty[] properties =
        AvaloniaPropertyRegistry
            .Instance
            .GetRegistered(typeof(T))
            .Where(_ => !_.IsReadOnly)
            .ToArray();

    public override void Write(VerifyJsonWriter writer, T value)
    {
        writer.WriteStartObject();
        var typeHandling = writer.Serializer.TypeNameHandling;
        if (typeHandling != TypeNameHandling.All &&
            typeHandling != TypeNameHandling.Objects)
        {
            writer.WriteMember(value, value.GetType(), "Type");
        }

        foreach (var property in properties)
        {
            WriteProperty(writer, value, property);
        }

        if (value is Panel panel)
        {
            writer.WriteMember(value, panel.Children, "Children");
        }

        writer.WriteEndObject();
    }

    static void WriteProperty(VerifyJsonWriter writer, T value, AvaloniaProperty property)
    {
        var diagnostic = value.GetDiagnostic(property);
        if (diagnostic.Priority != BindingPriority.LocalValue)
        {
            return;
        }

        var propertyValue = diagnostic.Value;
        if (ReferenceEquals(propertyValue, value))
        {
            return;
        }

        writer.WriteMember(value, propertyValue, property.Name);
    }
}