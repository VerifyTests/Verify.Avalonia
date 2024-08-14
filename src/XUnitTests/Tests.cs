[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class Tests
{
    [AvaloniaFact]
    public Task Recursive()
    {
        var window = new RecursiveWindow();

        return Verify(window);
    }
}