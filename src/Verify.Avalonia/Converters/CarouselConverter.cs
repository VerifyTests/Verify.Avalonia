class CarouselConverter :
    WriteOnlyJsonConverter<Carousel>
{
    public override void Write(VerifyJsonWriter writer, Carousel value)
    {
        writer.WriteStartObject();
        WriteMembers(writer, value);
        SelectingItemsControlConverter.WriteMembers(writer, value);
        writer.WriteEndObject();
    }

    public static void WriteMembers(VerifyJsonWriter writer, Carousel value)
    {
         writer.WriteMember(value, value.PageTransition, "PageTransition");
    }
}
