# <img src="/src/icon.png" height="30px"> Verify.Avalonia

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/5ywtfx5oc257d4tr?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-avalonia)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Avalonia.svg)](https://www.nuget.org/packages/Verify.Avalonia/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of [Avalonia UIs](https://avaloniaui.net/).<!-- singleLineInclude: intro. path: /docs/intro.include.md -->


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Avalonia) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](https://raw.githubusercontent.com/VerifyTests/Verify.Avalonia/refs/heads/main/docs/zzz.png)](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Avalonia)<!-- endInclude -->


## Getting Started

The test project needs a `ModuleInitializer` and an Avalonia application with a `Style`.

<!-- snippet: src/StandaloneExampleTest.XUnit/VerifyAvaloniaSetupApplication.cs -->
<a id='snippet-src/StandaloneExampleTest.XUnit/VerifyAvaloniaSetupApplication.cs'></a>
```cs
[assembly: AvaloniaTestApplication(typeof(VerifyAvaloniaSetupApplication))]

public class VerifyAvaloniaSetupApplication : Application
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageMagick.RegisterComparers(.24);
        VerifierSettings.InitializePlugins();
    }

    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder
            .Configure<VerifyAvaloniaSetupApplication>()
            .UseSkia()
            .UseHeadless(
                new()
                {
                    UseHeadlessDrawing = false
                });

    public VerifyAvaloniaSetupApplication() =>
        Styles.Add(new FluentTheme());
}
```
<sup><a href='/src/StandaloneExampleTest.XUnit/VerifyAvaloniaSetupApplication.cs#L1-L24' title='Snippet source file'>snippet source</a> | <a href='#snippet-src/StandaloneExampleTest.XUnit/VerifyAvaloniaSetupApplication.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

And add the following NuGet packages:

  - https://nuget.org/packages/Verify.Avalonia/
  - https://nuget.org/packages/Avalonia.Headless.XUnit/
  - https://nuget.org/packages/Avalonia.Themes.Fluent/
  - https://nuget.org/packages/Avalonia.Skia/


## More details

**See [Milestones](../../milestones?state=closed) for release notes.**

Leverages [Avalonia Headless Testing](https://docs.avaloniaui.net/docs/next/concepts/headless).

See [Headless Testing with XUnit](https://docs.avaloniaui.net/docs/next/concepts/headless/headless-xunit) and [Headless Testing with NUnit](https://docs.avaloniaui.net/docs/next/concepts/headless/headless-nunit) for more information.


### ModuleInitializer

<!-- snippet: Enable -->
<a id='snippet-Enable'></a>
```cs
[ModuleInitializer]
public static void Init()
{
    VerifyImageMagick.RegisterComparers(0.17);
    VerifyAvalonia.Initialize();
}
```
<sup><a href='/src/NUnitTests/ModuleInit.cs#L3-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-Enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

This sample uses [Verify.ImageMagick](https://github.com/VerifyTests/Verify.ImageMagick) to ignore small rendering differences that are expected between different operating systems.

Other [comparers](https://github.com/VerifyTests/Verify/blob/main/docs/comparer.md) options: 

 * https://github.com/VerifyTests/Verify.ImageHash
 * https://github.com/VerifyTests/Verify.ImageMagick
 * https://github.com/VerifyTests/Verify.Phash
 * https://github.com/VerifyTests/Verify.ImageSharp.Compare


### Verify.CommunityToolkit.Mvvm

Many Avalonia projects use [CommunityToolkit.Mvvm](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/). To ensure proper serialization of MVVM commands, use [Verify.CommunityToolkit.Mvvm](https://github.com/VerifyTests/Verify.CommunityToolkit.Mvvm).


### InternalsVisibleTo

Ensure tests projects have InternalsVisibleTo configured in the target app so tests can use generated controls by name.

<!-- snippet: InternalsVisibleTo -->
<a id='snippet-InternalsVisibleTo'></a>
```csproj
<ItemGroup>
  <InternalsVisibleTo Include="NUnitTests" />
  <InternalsVisibleTo Include="XUnitTests" />
</ItemGroup>
```
<sup><a href='/src/TestableApp/TestableApp.csproj#L20-L25' title='Snippet source file'>snippet source</a> | <a href='#snippet-InternalsVisibleTo' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Initialize AvaloniaTestApplication

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


### Window Test

<!-- snippet: XunitTests/CalculatorTests.cs -->
<a id='snippet-XunitTests/CalculatorTests.cs'></a>
```cs
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
```
<sup><a href='/src/XUnitTests/CalculatorTests.cs#L1-L24' title='Snippet source file'>snippet source</a> | <a href='#snippet-XunitTests/CalculatorTests.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Result in the following snapshots


#### Image

[Should_Add_Numbers.verified.verified.png](/src/XUnitTests/CalculatorTests.Should_Add_Numbers.verified.png):

<img src="/src/XUnitTests/CalculatorTests.Should_Add_Numbers.verified.png" width="250px">


#### Text

<!-- snippet: XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt -->
<a id='snippet-XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt'></a>
```txt
{
  Type: MainWindow,
  SizeToContent: WidthAndHeight,
  Title: Simple Calculator,
  CanResize: false,
  Content: {
    Type: StackPanel,
    Spacing: 10.0,
    Width: 280.0,
    Height: 175.0,
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
            Command: MainWindowViewModel.Add,
            Content: +,
            Name: AddButton
          },
          {
            Type: Button,
            Command: MainWindowViewModel.Subtract,
            Content: -,
            Name: SubtractButton
          },
          {
            Type: Button,
            Command: MainWindowViewModel.Multiply,
            Content: *,
            Name: MultiplyButton
          },
          {
            Type: Button,
            Command: MainWindowViewModel.Divide,
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
  Height: 195.0,
  IsVisible: true,
  DataContext: {
    FirstOperand: 10.0,
    SecondOperand: 20.0,
    Result: 30,
    AddCommand: MainWindowViewModel.Add,
    SubtractCommand: MainWindowViewModel.Subtract,
    MultiplyCommand: MainWindowViewModel.Multiply,
    DivideCommand: MainWindowViewModel.Divide
  }
}
```
<sup><a href='/src/XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt#L1-L87' title='Snippet source file'>snippet source</a> | <a href='#snippet-XUnitTests/CalculatorTests.Should_Add_Numbers.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### UserControl Test

Given the control:

<!-- snippet: MyUserControl.axaml -->
<a id='snippet-MyUserControl.axaml'></a>
```axaml
<UserControl xmlns="https://github.com/avaloniaui"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             Width="200"
             Height="100"
             Background="LightGray"
             x:Class="TestableApp.MyUserControl">
    <StackPanel Spacing="10" Margin="10" HorizontalAlignment="Left" Orientation="Vertical">
        <TextBlock Text="Welcome to Avalonia!" />
        <Button Content="Button" />
    </StackPanel>
</UserControl>
```
<sup><a href='/src/TestableApp/MyUserControl.axaml#L1-L11' title='Snippet source file'>snippet source</a> | <a href='#snippet-MyUserControl.axaml' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

And the test:

<!-- snippet: XunitTests/MyUserControlTests.cs -->
<a id='snippet-XunitTests/MyUserControlTests.cs'></a>
```cs
public class MyUserControlTests
{
    [AvaloniaFact]
    public Task Render()
    {
        var control = new MyUserControl();
        return Verify(control);
    }
}
```
<sup><a href='/src/XUnitTests/MyUserControlTests.cs#L1-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-XunitTests/MyUserControlTests.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Result in the following snapshots


#### Image

[Should_Add_Numbers.verified.verified.png](/src/XUnitTests/MyUserControlTests.Render.verified.png):

<img src="/src/XUnitTests/MyUserControlTests.Render.verified.png" width="250px">


#### Text

<!-- snippet: XUnitTests/MyUserControlTests.Render.verified.txt -->
<a id='snippet-XUnitTests/MyUserControlTests.Render.verified.txt'></a>
```txt
{
  Type: MyUserControl,
  Content: {
    Type: StackPanel,
    Spacing: 10.0,
    Orientation: Vertical,
    Margin: 10,
    HorizontalAlignment: Left,
    Children: [
      {
        Type: TextBlock,
        Text: Welcome to Avalonia!
      },
      {
        Type: Button,
        Content: Button
      }
    ]
  },
  Background: LightGray,
  Width: 200.0,
  Height: 100.0
}
```
<sup><a href='/src/XUnitTests/MyUserControlTests.Render.verified.txt#L1-L23' title='Snippet source file'>snippet source</a> | <a href='#snippet-XUnitTests/MyUserControlTests.Render.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## IncludeThemeVariant

The `VerifyAvalonia.IncludeThemeVariant()` method is used to include both `ThemeVariant.Light` and `ThemeVariant.Dark` variants when rendering UIs.

<!-- snippet: EnableIncludeThemeVariant -->
<a id='snippet-EnableIncludeThemeVariant'></a>
```cs
[ModuleInitializer]
public static void Init()
{
    VerifyAvalonia.IncludeThemeVariant();
    VerifierSettings.InitializePlugins();
}
```
<sup><a href='/src/IncludeThemeVariantTests/ModuleInit.cs#L3-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-EnableIncludeThemeVariant' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Then given the same `CalculatorTests` will produce the `verified.txt` as above, but will now produce two pngs, the first for `ThemeVariant.Light` and the second for `ThemeVariant.Dark`:

<img src="/src/IncludeThemeVariantTests/CalculatorTests.Render%23light.verified.png" width="250px">

<img src="/src/IncludeThemeVariantTests/CalculatorTests.Render%23dark.verified.png" width="250px">

## Additional Control Libraries

The `VerifyAvalonia.AddAvaloniaConvertersForAssembly` method is used to include converters for additional control assemblies.

<!-- snippet: InitAddAvaloniaConvertersForAssembly -->
<a id='snippet-InitAddAvaloniaConvertersForAssembly'></a>
```cs
[ModuleInitializer]
public static void Init()
{
    // FluentAvalonia
    VerifyAvalonia.AddAvaloniaConvertersForAssemblyOfType<NavigationView>();
    VerifyImageMagick.RegisterComparers(0.17);
    VerifierSettings.InitializePlugins();
}
```
<sup><a href='/src/FluentAvaloniaTests/ModuleInit.cs#L3-L14' title='Snippet source file'>snippet source</a> | <a href='#snippet-InitAddAvaloniaConvertersForAssembly' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
