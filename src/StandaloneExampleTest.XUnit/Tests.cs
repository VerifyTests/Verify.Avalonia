[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class Tests
{
    [AvaloniaFact]
    public Task Test()
    {
        var testSubject = new Button
        {
            Content = "Click me!",
            Width= 75,
            Height= 32
        };

        var window = new Window
        {
            Content = testSubject,
            SizeToContent = SizeToContent.WidthAndHeight,
        };

        return Verify(window);
    }
}