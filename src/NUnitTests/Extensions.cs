public static class Extensions
{
    public static string ToLowerFirstChar(this string input) =>
        char.ToLower(input[0]) + input[1..];
}