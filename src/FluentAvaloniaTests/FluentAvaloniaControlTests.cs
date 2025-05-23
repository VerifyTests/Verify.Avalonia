using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

[TestFixture]
public class FluentAvaloniaControlTests
{
    [AvaloniaTest]
    public Task RenderNavigationView()
    {
        var control = new NavigationView
        {
            PaneDisplayMode = NavigationViewPaneDisplayMode.LeftCompact,
            IsSettingsVisible = true,
            Header = new TextBlock {Text = "The Header"},
            MenuItems =
            [
                new NavigationViewItem { Content = "1 Nav Item" },
                new NavigationViewItem
                {
                    Content = "2 Nav Item",
                    IconSource = new SymbolIconSource {Symbol = Symbol.Admin}
                },
                new NavigationViewItem { Content = "3 Nav Item" },
            ],
            Content = "This is the content!"
        };
        return Verify(new UserControl { Content = control });
    }
}