[![version][version-badge]][changelog] [![license][license-badge]][license]

# C&#35; course

## A collection of solved tasks

I am using [Visual Studio Code] for editing the necessary files. I followed the
editor's official website's [instructions].

Added editor extensions:

*   [C#]
*   [C# FixFormat]
*   [C# Extensions]

The [.NET core] has been installed. And I made a new console application.

---

## Setup

```sh
> mkdir CsharpCourse && cd $_
> git flow init -d
> git remote add origin git@github.com:@user/@repo
> dotnet new console --output . --name CsharpCourse
> git add .
> git commit -m "Initial files added"
```

---

## You can run a specific task

```sh
> dotnet run --lesson 2 --task 5
```

### Avalilable tasks per lessons

| Lessons | Tasks | From | To |
|---|:---:|:---:|---|
| Lesson 01 | <span style="color:green">&#10003;</span> | 1 | 1 |
| Lesson 02 | <span style="color:green">&#10003;</span> | 1 | 9 |

[visual studio code]: https://code.visualstudio.com 'Visual Studio Code'
[instructions]: https://code.visualstudio.com/docs/languages/csharp 'instructions'
[c#]: https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp 'C#'
[c# fixformat]: https://marketplace.visualstudio.com/items?itemName=Leopotam.csharpfixformat 'C# FixFormat'
[c# extensions]: https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions 'C# Extensions'
[.net core]: https://microsoft.com/net/core '.NET core'
[gitflow]: https://jeffkreeftmeijer.com/git-flow 'GitFlow'
[license-badge]: https://img.shields.io/badge/license-MIT-blue.svg
[license]: ./LICENSE 'MIT license'

[version-badge]: https://img.shields.io/badge/version-1.0.4-blue.svg
[changelog]: ./CHANGELOG.md 'Changelog'
