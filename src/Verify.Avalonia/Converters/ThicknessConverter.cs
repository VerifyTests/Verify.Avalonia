class ThicknessConverter :
    WriteOnlyJsonConverter<Thickness>
{
    public override void Write(VerifyJsonWriter writer, Thickness value)
    {
        var top = value.Top;
        if (top == value.Left &&
            top == value.Right &&
            top == value.Bottom)
        {
            writer.WriteValue(top.ToString(CultureInfo.InvariantCulture));
            return;
        }

        writer.WriteValue(value.ToString());
    }
}