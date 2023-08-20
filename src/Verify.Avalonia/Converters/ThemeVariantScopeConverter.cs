class ThemeVariantScopeConverter :
    WriteOnlyJsonConverter<ThemeVariantScope>
{
    public override void Write(VerifyJsonWriter writer, ThemeVariantScope value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        DecoratorConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, ThemeVariantScope value)
    {
         writer.WriteMember(value, value.RequestedThemeVariant, "RequestedThemeVariant");
    }
}
