namespace VerifyTests;

public class CornerRadiusConverter :
    WriteOnlyJsonConverter<CornerRadius>
{
    public override void Write(VerifyJsonWriter writer, CornerRadius value) =>
        writer.WriteValue(value.ToString());
}