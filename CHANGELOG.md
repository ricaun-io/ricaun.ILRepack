# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.0] / 2024-09-03 - 2025-01-16
- Update `ILRepack` to version `2.0.36`.
- Add `ILRepack` options using `PropertyGroups`.
- Add `ILRepackIgnoreReferences` to ignore references to be repack.
- Add `Tests` to validate the repack.
- Add `DevelopmentDependency` to `NuGet` package (Fix: #1)
- Update main target to use `BeforeTargets` to create output file already repacked.
- Update `ILRepackDeleteTarget` to use `ILRepackEnabled` condition.
- Update `ILRepackIgnoreReferences` to ignore all files starts with include name.

[vNext]: ../../compare/1.0.0...HEAD
[1.0.0]: ../../compare/1.0.0