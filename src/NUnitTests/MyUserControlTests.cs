[TestFixture]
public class MyUserControlTests
{
    [AvaloniaTest]
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