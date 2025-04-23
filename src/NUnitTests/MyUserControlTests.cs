[TestFixture]
public class MyUserControlTests
{
    [AvaloniaTest]
    public Task Render()
    {
        var control = new MyUserControl();
        return Verify(control);
    }
}