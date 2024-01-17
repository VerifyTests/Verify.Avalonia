public class Tests
{
    [AvaloniaFact]
    public Task Recursive()
    {
        var window = new RecursiveWindow();

        window.Show();

        return Verify(window);
    }
}