public class Tests
{
    [AvaloniaFact]
    public Task Recursive()
    {
        var window = new RecursiveWindow();

        return Verify(window);
    }
}