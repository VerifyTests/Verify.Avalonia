namespace TestableApp;

public partial class RecursiveWindow : Window
{
    public RecursiveWindow()
    {
        InitializeComponent();
        DataContext = this;
    }
}