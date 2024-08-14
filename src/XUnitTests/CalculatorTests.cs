[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class CalculatorTests
{
    [AvaloniaFact]
    public Task Should_Add_Numbers()
    {
        var window = new MainWindow
        {
            DataContext = new MainWindowViewModel()
        };

        window.Show();

        // Set values to the input boxes
        window.FirstOperandInput.Text = "10";
        window.SecondOperandInput.Text = "20";

        // Raise click event on the button:
        window.AddButton.Focus();
        window.KeyPressQwerty(PhysicalKey.Enter, RawInputModifiers.None);

        Assert.Equal("30", window.ResultBox.Text);
        return Verify(window);
    }
}