# <img src="/src/icon.png" height="30px"> Verify.Avalonia

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/5ywtfx5oc257d4tr?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-avalonia)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Avalonia.svg)](https://www.nuget.org/packages/Verify.Avalonia/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of Avalonia UIs.

**Currently only supported in XUnit since [[AvaloniaTest] results in incorrect TestContext.CurrentContext.Test.MethodName in NUnit](https://github.com/AvaloniaUI/Avalonia/issues/12590)**

Leverages [Headless Testing](https://docs.avaloniaui.net/docs/next/concepts/headless).

See [Headless Testing with XUnit](https://docs.avaloniaui.net/docs/next/concepts/headless/headless-xunit) and [Headless Testing with NUnit](https://docs.avaloniaui.net/docs/next/concepts/headless/headless-nunit) for more information.


## NuGet package

https://nuget.org/packages/Verify.Avalonia/


## Enable


<!-- snippet: Enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyAvalonia.Initialize();
```
<sup><a href='/src/NUnitTests/ModuleInit.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

A visual element (Window/Page/Control etc) can then be verified as follows:


## InternalsVisibleTo

Ensure tests projects have InternalsVisibleTo configured in the target app so tests can use generated controls by name.

<!-- snippet: InternalsVisibleTo -->
<a id='snippet-internalsvisibleto'></a>
```csproj
<ItemGroup>
  <InternalsVisibleTo Include="NUnitTests" />
  <InternalsVisibleTo Include="XUnitTests" />
</ItemGroup>
```
<sup><a href='/src/TestableApp/TestableApp.csproj#L22-L27' title='Snippet source file'>snippet source</a> | <a href='#snippet-internalsvisibleto' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Test

<!-- snippet: XunitTests/CalculatorTests.cs -->
<a id='snippet-XunitTests/CalculatorTests.cs'></a>
```cs
[UsesVerify]
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

        // Set values to the input boxes by simulating text input:
        window.FirstOperandInput.Focus();
        window.KeyTextInput("10");

        // Or directly to the control:
        window.SecondOperandInput.Text = "20";

        // Raise click event on the button:
        window.AddButton.Focus();
        window.KeyPress(Key.Enter, RawInputModifiers.None);

        Assert.Equal("30", window.ResultBox.Text);
        return Verify(window);
    }

    [AvaloniaFact]
    public Task Cannot_Divide_By_Zero()
    {
        var window = new MainWindow
        {
            DataContext = new MainWindowViewModel()
        };

        window.Show();

        // Set values to the input boxes by simulating text input:
        window.SecondOperandInput.Text = "10";
        window.SecondOperandInput.Text = "0";

        // Raise click event on the button:
        window.DivideButton.Focus();
        window.KeyPress(Key.Enter, RawInputModifiers.None);

        Assert.Equal("Cannot divide by zero!", window.ResultBox.Text);
        return Verify(window);
    }
}
```
<sup><a href='/src/XUnitTests/CalculatorTests.cs#L1-L50' title='Snippet source file'>snippet source</a> | <a href='#snippet-XunitTests/CalculatorTests.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Result in the following snapshot


[Cannot_Divide_By_Zero.verified.verified.png](/src/XUnitTests/CalculatorTests.Cannot_Divide_By_Zero.verified.png):

<img src="/src/XUnitTests/CalculatorTests.Cannot_Divide_By_Zero.verified.png" width="200px">

## Icon

[Gem](https://thenounproject.com/term/gem/2247823/) designed by [Adnen Kadri](https://thenounproject.com/adnen.kadri/) from [The Noun Project](https://thenounproject.com).
