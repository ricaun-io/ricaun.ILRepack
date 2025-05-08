# ricaun.ILRepack

[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](https://github.com/ricaun-io/ricaun.ILRepack)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](https://github.com/ricaun-io/ricaun.ILRepack/actions/workflows/Build.yml/badge.svg)](https://github.com/ricaun-io/ricaun.ILRepack/actions)
[![Release](https://img.shields.io/nuget/v/ricaun.ILRepack?logo=nuget&label=release&color=blue)](https://www.nuget.org/packages/ricaun.ILRepack)

`ricaun.ILRepack` is a basic repack for .NET assemblies. Uses the package [ILRepack](https://github.com/gluck/il-repack) to repack the assembly using `Target` to replace the original assembly to the repack assembly with all the dependencies included.

## Installation

Install the package using the `NuGet` package manager or using `PackageReference`.

```xml
<PackageReference Include="ricaun.ILRepack" Version="*">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
</PackageReference>
```

By default the repack is enabled when the package is used, and all the dependencies is repack and removed from the output.

## Version

The package [ILRepack](https://github.com/gluck/il-repack) with version `2.0.39` is used by default to repack the assembly, if the your project contains a different version, the package will use the version from the package.

```xml
<PackageReference Include="ILRepack" Version="*">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
</PackageReference>
```

## Configuration

### PropertyGroups
Property Name | Default Value | Description
-------------|--------|-------------
`ILRepackEnabled`| `true` | Enable / Disable ILRepack target task.
`ILRepackDeleteEnabled`| `true` | Enable / Disable delete dependencies repacked from output.
`ILRepackImportance` | `High` | Log importance to show in the console. (`Low` or `High`)
`ILRepackCommandImportance` | `Low` | Log importance from the `ILRepack.exe` to show in the console. (`Low` or `High`)
`ILRepackCommandExtra` |  | Extra command to be used in the `ILRepack.exe`.

```xml
<PropertyGroup>
  <ILRepackEnabled>true</ILRepackEnabled>
  <ILRepackDeleteEnabled>true</ILRepackDeleteEnabled>
  <ILRepackImportance>High</ILRepackImportance>
  <ILRepackCommandImportance>Low</ILRepackCommandImportance>
  <ILRepackCommandExtra></ILRepackCommandExtra>
</PropertyGroup>
```

## ItemGroup

Item Group | Description
-------------|-------------
`ILRepackIgnoreReferences`| Ignore references to be repack.

```xml
<ItemGroup>
  <ILRepackIgnoreReferences Include="Newtonsoft;System.Text" />
</ItemGroup>
```

Ignore references to be repack with file name start with `Newtonsoft` and `System.Text`.

## Release

* [Latest release](https://github.com/ricaun-io/ricaun.ILRepack/releases/latest)

## License

This project is [licensed](LICENSE) under the [MIT License](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](https://github.com/ricaun-io/ricaun.ILRepack/stargazers)!