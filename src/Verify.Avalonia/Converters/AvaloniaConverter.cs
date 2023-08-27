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
            WriteMember(writer, value, property);
        }

        if (value is Panel panel)
        {
            writer.WriteMember(value, panel.Children, "Children");
        }

        writer.WriteEndObject();
    }

    static void WriteMember(VerifyJsonWriter writer, T parent, AvaloniaProperty property)
    {
        var diagnostic = parent.GetDiagnostic(property);
        if (diagnostic.Priority != BindingPriority.LocalValue)
        {
            return;
        }

        var value = diagnostic.Value;
        if (ReferenceEquals(value, parent))
        {
            return;
        }

        writer.WriteMember(parent, value, property.Name);
    }
}