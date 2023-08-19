# <img src="/src/icon.png" height="30px"> Verify.Xaml

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/o2iy3b7k9le0ntps?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-xaml)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Xaml.svg)](https://www.nuget.org/packages/Verify.Xaml/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of Xaml UIs.



## NuGet package

https://nuget.org/packages/Verify.Xaml/


## Usage

<!-- snippet: Enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyAvalonia.Initialize();
```
<sup><a href='/src/Tests/ModuleInit.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

A visual element (Window/Page/Control etc) can then be verified as follows:


## Icon

[Gem](https://thenounproject.com/term/gem/2247823/) designed by [Adnen Kadri](https://thenounproject.com/adnen.kadri/) from [The Noun Project](https://thenounproject.com).
