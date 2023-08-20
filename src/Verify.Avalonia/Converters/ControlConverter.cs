class ControlConverter :
    WriteOnlyJsonConverter<Control>
{
    public override void Write(VerifyJsonWriter writer, Control value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        InputElementConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Control value)
    {
         writer.WriteMember(value, value.FocusAdorner, "FocusAdorner");
         writer.WriteMember(value, value.DataTemplates, "DataTemplates");
         writer.WriteMember(value, value.ContextMenu, "ContextMenu");
         writer.WriteMember(value, value.ContextFlyout, "ContextFlyout");
         writer.WriteMember(value, value.IsLoaded, "IsLoaded");
         writer.WriteMember(value, value.Tag, "Tag");
    }
}
