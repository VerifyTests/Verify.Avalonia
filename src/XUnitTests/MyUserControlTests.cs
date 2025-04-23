public class MyUserControlTests
{
    [AvaloniaFact]
    public Task Render()
    {
        var control = new MyUserControl();
        return Verify(control);
    }
}