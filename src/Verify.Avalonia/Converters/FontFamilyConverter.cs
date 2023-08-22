using Avalonia.Media;

namespace VerifyTests;

public class FontFamilyConverter :
    WriteOnlyJsonConverter<FontFamily>
{
    public override void Write(VerifyJsonWriter writer, FontFamily value) =>
        writer.WriteValue(value.Name);
}