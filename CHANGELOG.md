# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.2] / 2025-02-24
### Features
- Update `ILRepack` version `2.0.39`.
### Updates
- Add `PackageReference` to find the `ILRepack` version.
- Update `ILRepackDelete` to delete `pdb` files.

## [1.0.1] / 2025-02-03
### Features
- Update `ILRepack` version `2.0.38`.
### Experimental Features
- `ILRepackRenameEnabled` property to rename the output file to change the assembly name with revision.
### Updates
- Update `ILRepackVersion` with condition.
- Update to show `TargetFramework` in the console.
### Sample
- Only include `System.Text.Json` in net framework, issue with repack and net core.

## [1.0.0] / 2024-09-03 - 2025-01-30
### Features
- Support `ILRepack` version `2.0.36`.
- Repack all dependencies before `CopyFilesToOutputDirectory`.
### Updates
- Add `ILRepack` options using `PropertyGroups`.
- Add `ILRepackIgnoreReferences` to ignore references to be repack.
- Add `Tests` to validate the repack.
- Add `DevelopmentDependency` to `NuGet` package (Fix: #1)
- Update main target to use `BeforeTargets` to create output file already repacked.
- Update `ILRepackDeleteTarget` to use `ILRepackEnabled` condition.
- Update `ILRepackIgnoreReferences` to ignore all files starts with include name.

[vNext]: ../../compare/1.0.0...HEAD
[1.0.2]: ../../compare/1.0.1...1.0.2
[1.0.1]: ../../compare/1.0.0...1.0.1
[1.0.0]: ../../compare/1.0.0