namespace VerifyTests;

public interface IAvaloniaConverter<in T> where T : Visual
{
    static abstract bool MemberHasValue(T target, string member, object? value);
}