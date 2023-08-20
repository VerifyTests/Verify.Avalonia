using Argon;

[TestFixture]
public class CalculatorTests
{
    [AvaloniaTest]
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
        window.KeyPress(Key.Enter, RawInputModifiers.None);

        Assert.That(window.ResultBox.Text, Is.EqualTo("30"));
        return Verify(window).AddExtraSettings(_=>_.TypeNameHandling = TypeNameHandling.All);
    }

    // [AvaloniaTest]
    // public Task Cannot_Divide_By_Zero()
    // {
    //     var window = new MainWindow
    //     {
    //         DataContext = new MainWindowViewModel()
    //     };
    //
    //     window.Show();
    //
    //     // Set values to the input boxes
    //     window.SecondOperandInput.Text = "10";
    //     window.SecondOperandInput.Text = "0";
    //
    //     // Raise click event on the button:
    //     window.DivideButton.Focus();
    //     window.KeyPress(Key.Enter, RawInputModifiers.None);
    //
    //     Assert.That(window.ResultBox.Text, Is.EqualTo("Cannot divide by zero!"));
    //     return Verify(window);
    // }
}