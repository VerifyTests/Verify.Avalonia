class FlyoutPresenterConverter :
    WriteOnlyJsonConverter<FlyoutPresenter>
{
    public override void Write(VerifyJsonWriter writer, FlyoutPresenter value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        ContentControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, FlyoutPresenter value)
    {
    }
}
