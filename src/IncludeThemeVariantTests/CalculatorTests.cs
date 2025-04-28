[TestFixture]
public class CalculatorTests
{
    [AvaloniaTest]
    public Task Render()
    {
        var window = new MainWindow
        {
            DataContext = new MainWindowViewModel()
        };

        return Verify(window);
    }
}