public class MyUserControlTests
{
    [AvaloniaFact]
    public Task Render()
    {
        var control = new MyUserControl();
        var window = new Window
        {
            Content = control
        };

        window.Show();
        return Verify(window);
    }
}