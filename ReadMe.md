# Uno Platform port of Windows Community Toolkit

This port allows for [Uno Platform based](https://github.com/unoplatform/uno) apps to use [Windows Community Toolkit](https://github.com/Microsoft/WindowsCommunityToolkit)
on Windows, iOS, macOS, Android, WebAssembly and Linux.

The following packages are available:
- Uno.Microsoft.Toolkit [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit)
- Uno.Microsoft.Toolkit.Uwp [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp)
- Uno.Microsoft.Toolkit.Uwp.Connectivity [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.Connectivity.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.Connectivity)
- Uno.Microsoft.Toolkit.Uwp.DeveloperTools [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.DeveloperTools.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.DeveloperTools)
- Uno.Microsoft.Toolkit.Uwp.UI [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI)
- Uno.Microsoft.Toolkit.Uwp.UI.Animations [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Animations.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Animations)
- Uno.Microsoft.Toolkit.Uwp.UI.Behaviors [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Behaviors.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Behaviors)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.Core [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Core.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Core)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.DataGrid [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.DataGrid.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.Input [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Input.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Input)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.Layout [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Layout.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Layout)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.Markdown [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Markdown.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Markdown)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.Media [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Media.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Media)
- Uno.Microsoft.Toolkit.Uwp.UI.Controls.Primitives [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Primitives.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Controls.Primitives)
- Uno.Microsoft.Toolkit.Uwp.UI.Media [![NuGet](https://img.shields.io/nuget/v/Uno.Microsoft.Toolkit.Uwp.UI.Media.svg)](https://www.nuget.org/packages/Uno.Microsoft.Toolkit.Uwp.UI.Media)

## Using the Uno Platform Windows Community Toolkit packages

These packages are providing support for the Uno Platform supported targets (iOS, Android, macOS, WebAssembly and Skia GTK/WPF/Tizen). 

On Windows projects (the UWP head), please install the official [Windows Community Toolkit packages](https://github.com/Microsoft/WindowsCommunityToolkit).

If you are building for library, use the following to conditionally include the toolkit builds:

```xml
<ItemGroup Condition="'$(TargetFramework)' == 'uap10.0.17763'">
	<PackageReference Include="Microsoft.Toolkit.Uwp.Controls" Version="7.0.0" />
</ItemGroup>
<ItemGroup Condition="'$(TargetFramework)' != 'uap10.0.17763'">
	<PackageReference Include="Uno.Microsoft.Toolkit.Uwp.Controls" Version="7.0.0" />
</ItemGroup>
```