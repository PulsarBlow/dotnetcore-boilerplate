<p align="center">
  <img alt=".NET Core Boilerplate" src="assets/icon.svg" width="90" />
</p>
<h1 align="center">
  .NET Core Boilerplate
</h1>

<h2 align="center">A lightweight .NET Core Class Library boilerplate, stripped to its bare minimum, powered by an optimized build system</h2>

![Release](https://github.com/PulsarBlow/dotnetcore-boilerplate/workflows/Release/badge.svg) ![Continuous Integration](https://github.com/PulsarBlow/dotnetcore-boilerplate/workflows/Continuous%20Integration/badge.svg)

.NET Core Boilerplate is a boilerplate you can use to rapidly boostrap a .NET Core Class Library. It is a polished empty shell (no functional behavior) which helps to enforce good project layout practices.\
It is designed with a complete CI/CD flow targeting a public Nuget package publication.

## 👟 Getting started

### Prepare your environment

* Download and install the latest .NET Core SDK - [.NET Core 3.1](https://github.com/dotnet/core/blob/master/release-notes/3.1/README.md)

### Build and test

Start by cloning the repository

```shell
git clone https://github.com/PulsarBlow/dotnetcore-boilerplate
```

Build

```shell
dotnet build
```

Test with coverage

> Note that the "XPlat Code Coverage" data collector friendly name cannot be changed. It is a constant name embeded inside the Coverlet data collector we use to collect code coverage.

```shell
$ dotnet test --collect:"XPlat Code Coverage" --settings ./build/coverlet.runsettings -r .build/
```

### Publish package

The package publication workflow is [Github Flow](https://githubflow.github.io/) based. That is, the master branch is always deployable.

When you create a new Github release, a Github event is triggered at the repository level and caught be the Github Actions underlying system. Github actions checks if there is a workflow bound to that event and run it if it finds one.

See the [Release workflow](.github/workflows/release.yml) file for more details

## 🎛 Project properties

To improve maintainability of project dependencies and configuration attributes, global properties have been exported into importable *.props files:

```bash
./props
├- package.props            # Nuget package project properties
└- common.props             # Common properties for any project (class lib, test, packable, not packable..)
   ├- dependencies.props    # Shared dependencies, easier to align dependency version across projects
   └- version.props         # Share version, easier to align version across projects
```

## 🦄 Attributions

.NET Core Boilerplate icons made by [Smashicons](https://www.flaticon.com/authors/smashicons) from [Flaticon](https://www.flaticon.com/)