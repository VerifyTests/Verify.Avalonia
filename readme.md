# <img src="/src/icon.png" height="30px"> Verify.Avalonia

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/5ywtfx5oc257d4tr?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-avalonia)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Avalonia.svg)](https://www.nuget.org/packages/Verify.Avalonia/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of [Avalonia UIs](https://avaloniaui.net/).

**Currently only supported in XUnit since [AvaloniaTestAttribute results in incorrect TestContext.Test.MethodName in NUnit](https://github.com/AvaloniaUI/Avalonia/issues/12590)**

Leverages [Avalonia Headless Testing](https://docs.avaloniaui.net/docs/next/concepts/headless).

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


## Initialize AvaloniaTestApplication

The `[AvaloniaTestApplication]` attribute wires the tests in the current project with the specific application. It needs to be defined once per project in any file. Verify.Avalonia requires that `UseHeadlessDrawing` is disabled and `.UseSkia()` is set.

<!-- snippet: src/XUnitTests/TestAppBuilder.cs -->
<a id='snippet-src/XUnitTests/TestAppBuilder.cs'></a>
```cs
[assembly: AvaloniaTestApplication(typeof(TestAppBuilder))]

public static class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<App>()
            .UseSkia()
            .UseHeadless(
                new()
                {
                    UseHeadlessDrawing = false
                });
}
```
<sup><a href='/src/XUnitTests/TestAppBuilder.cs#L1-L13' title='Snippet source file'>snippet source</a> | <a href='#snippet-src/XUnitTests/TestAppBuilder.cs' title='Start of snippet'>anchor</a></sup>
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

        // Set values to the input boxes
        window.FirstOperandInput.Text = "10";
        window.SecondOperandInput.Text = "20";

        // Raise click event on the button:
        window.AddButton.Focus();
        window.KeyPress(Key.Enter, RawInputModifiers.None);

        Assert.Equal("30", window.ResultBox.Text);
        return Verify(window);
    }
}
```
<sup><a href='/src/XUnitTests/CalculatorTests.cs#L1-L25' title='Snippet source file'>snippet source</a> | <a href='#snippet-XunitTests/CalculatorTests.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Result in the following snapshots

[Should_Add_Numbers.verified.verified.png](/src/XUnitTests/CalculatorTests.Should_Add_Numbers.verified.png):

<img src="/src/XUnitTests/CalculatorTests.Should_Add_Numbers.verified.png" width="250px">

<!-- snippet: XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt -->
<a id='snippet-XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt'></a>
```txt
{
  Type: MainWindow,
  SizeToContent: WidthAndHeight,
  Title: Simple Calculator,
  Icon: {},
  CanResize: false,
  Content: {
    Type: StackPanel,
    Spacing: 10.0,
    Margin: 10,
    HorizontalAlignment: Left,
    Children: [
      {
        Type: TextBox,
        Text: 10,
        Watermark: Operand 1,
        Name: FirstOperandInput
      },
      {
        Type: TextBox,
        Text: 20,
        Watermark: Operand 2,
        Name: SecondOperandInput
      },
      {
        Type: UniformGrid,
        Columns: 4,
        Children: [
          {
            Type: Button,
            Command: {
              Type: Action,
              Target: MainWindowViewModel,
              Method: Void Add()
            },
            Content: +,
            Name: AddButton
          },
          {
            Type: Button,
            Command: {
              Type: Action,
              Target: MainWindowViewModel,
              Method: Void Subtract()
            },
            Content: -,
            Name: SubtractButton
          },
          {
            Type: Button,
            Command: {
              Type: Action,
              Target: MainWindowViewModel,
              Method: Void Multiply()
            },
            Content: *,
            Name: MultiplyButton
          },
          {
            Type: Button,
            Command: {
              Type: Action,
              Target: MainWindowViewModel,
              Method: Void Divide()
            },
            Content: /,
            Name: DivideButton
          }
        ]
      },
      {
        Type: StackPanel,
        Spacing: 10.0,
        Orientation: Horizontal,
        Children: [
          {
            Type: TextBlock,
            Text: Result:
          },
          {
            Type: TextBlock,
            Text: 30,
            Name: ResultBox
          }
        ]
      }
    ]
  },
  Background: LightGray,
  Width: 300.0,
  Height: 185.0,
  IsVisible: true,
  DataContext: {
    FirstOperand: 10.0,
    SecondOperand: 20.0,
    Result: 30,
    AddCommand: {
      Type: Action,
      Target: MainWindowViewModel,
      Method: Void Add()
    },
    SubtractCommand: {
      Type: Action,
      Target: MainWindowViewModel,
      Method: Void Subtract()
    },
    MultiplyCommand: {
      Type: Action,
      Target: MainWindowViewModel,
      Method: Void Multiply()
    },
    DivideCommand: {
      Type: Action,
      Target: MainWindowViewModel,
      Method: Void Divide()
    }
  }
}
```
<sup><a href='/src/XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt#L1-L118' title='Snippet source file'>snippet source</a> | <a href='#snippet-XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
