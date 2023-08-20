class SplitViewConverter :
    WriteOnlyJsonConverter<SplitView>
{
    public override void Write(VerifyJsonWriter writer, SplitView value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, SplitView value)
    {
         writer.WriteMember(value, value.CompactPaneLength, "CompactPaneLength");
         writer.WriteMember(value, value.DisplayMode, "DisplayMode");
         writer.WriteMember(value, value.IsPaneOpen, "IsPaneOpen");
         writer.WriteMember(value, value.OpenPaneLength, "OpenPaneLength");
         writer.WriteMember(value, value.PaneBackground, "PaneBackground");
         writer.WriteMember(value, value.PanePlacement, "PanePlacement");
         writer.WriteMember(value, value.Pane, "Pane");
         writer.WriteMember(value, value.PaneTemplate, "PaneTemplate");
         writer.WriteMember(value, value.UseLightDismissOverlayMode, "UseLightDismissOverlayMode");
         writer.WriteMember(value, value.TemplateSettings, "TemplateSettings");
    }
}
