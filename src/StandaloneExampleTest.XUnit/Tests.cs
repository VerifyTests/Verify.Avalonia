public class Tests
{
    [AvaloniaFact]
    public Task Test()
    {
        var testSubject = new Button
        {
            Content = "Click me!"
        };

        var window = new Window
        {
            Content = testSubject,
            SizeToContent = SizeToContent.WidthAndHeight,
        };
        try
        {
            window.Show();
            return Verify(window);
        }
        finally
        {
            window.Close();
        }
    }
}