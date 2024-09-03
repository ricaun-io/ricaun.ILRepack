# ricaun.ILRepack

[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](../..)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](../../actions/workflows/Build.yml/badge.svg)](../../actions)

`ricaun.ILRepack` is a basic repack for .NET assemblies. Uses the package [ILRepack](https://github.com/gluck/il-repack) version `2.0.34` to repack the assembly using `Target` to replate the original dll to the repack dll.

## Installation

```xml
<PackageReference Include="ricaun.ILRepack" Version="*" />
```

By default the repack is enabled when the package is used, and all the dependencies is repack and removed from the output.

## Configuration

### PropertyGroups
Property Name | Default Value | Description
-------------|--------|-------------
`ILRepackEnabled`| `true` | Enable / Disable ILRepack target task.
`ILRepackDeleteEnabled`| `true` | Enable / Disable delete dependencies repacked from output.
`ILRepackImportance` | `Low` | Log importance to show in the console. (`Low` or `High`)
`ILRepackCommandImportance` | `Low` | Log importance from the `ILRepack.exe` to show in the console. (`Low` or `High`)
`ILRepackCommandExtra` | `` | Extra command to be used in the `ILRepack.exe`.

```xml
<PropertyGroup>
  <ILRepackEnabled>true</ILRepackEnabled>
  <ILRepackDeleteEnabled>true</ILRepackDeleteEnabled>
  <ILRepackImportance>Low</ILRepackImportance>
  <ILRepackCommandImportance>Low</ILRepackCommandImportance>
  <ILRepackCommandExtra></ILRepackCommandExtra>
</PropertyGroup>
```

## Todo
- [ ] Add option to ignore specific assembly/dependencies in the ILRepack.
- [ ] Delete dependencie debug file from the output.
- [ ] Remove dependencies to be copy from the output.

## Release

* [Latest release](../../releases/latest)

## License

This project is [licensed](LICENSE) under the [MIT License](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](../../stargazers)!