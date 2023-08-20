class MenuItemConverter :
    WriteOnlyJsonConverter<MenuItem>
{
    public override void Write(VerifyJsonWriter writer, MenuItem value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        HeaderedSelectingItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, MenuItem value)
    {
         writer.WriteMember(value, value.Command, "Command");
         writer.WriteMember(value, value.HotKey, "HotKey");
         writer.WriteMember(value, value.CommandParameter, "CommandParameter");
         writer.WriteMember(value, value.Icon, "Icon");
         writer.WriteMember(value, value.InputGesture, "InputGesture");
         writer.WriteMember(value, value.IsSelected, "IsSelected");
         writer.WriteMember(value, value.IsSubMenuOpen, "IsSubMenuOpen");
         writer.WriteMember(value, value.StaysOpenOnClick, "StaysOpenOnClick");
         writer.WriteMember(value, value.HasSubMenu, "HasSubMenu");
         writer.WriteMember(value, value.IsTopLevel, "IsTopLevel");
    }
}
