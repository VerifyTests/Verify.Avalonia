# <img src="/src/icon.png" height="30px"> Verify.Avalonia

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/5ywtfx5oc257d4tr?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-avalonia)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Avalonia.svg)](https://www.nuget.org/packages/Verify.Avalonia/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of Avalonia UIs.



## NuGet package

https://nuget.org/packages/Verify.Avalonia/


## Usage

<!-- snippet: Enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyAvalonia.Initialize();
```
<sup><a href='/src/NUnitTests/ModuleInit.cs#L6-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<a id='snippet-enable-1'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyAvalonia.Initialize();
```
<sup><a href='/src/XUnitTests/ModuleInit.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable-1' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

A visual element (Window/Page/Control etc) can then be verified as follows:


## Icon

[Gem](https://thenounproject.com/term/gem/2247823/) designed by [Adnen Kadri](https://thenounproject.com/adnen.kadri/) from [The Noun Project](https://thenounproject.com).
