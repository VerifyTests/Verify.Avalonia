namespace VerifyTests;

public class ThicknessConverter : WriteOnlyJsonConverter<Thickness>
{
    public override void Write(VerifyJsonWriter writer, Thickness value) =>
        writer.WriteValue(value.ToString());
}
public class CornerRadiusConverter : WriteOnlyJsonConverter<CornerRadius>
{
    public override void Write(VerifyJsonWriter writer, CornerRadius value) =>
        writer.WriteValue(value.ToString());
}
