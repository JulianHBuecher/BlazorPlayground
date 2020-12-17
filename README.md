# .NET Blazor 

## Table of Content
- [.NET Blazor](#net-blazor)
  - [Table of Content](#table-of-content)
  - [Blazor Tooling](#blazor-tooling)
    - [Visual Studio Code](#visual-studio-code)
  - [Project Structure](#project-structure)

## Blazor Tooling
### Visual Studio Code
For building a Blazor Server or a Blazor WebAssembly Project you could choose Visual Studio or Visual Studio Code as your IDE of choice.
In the following section a few commands for working with Blazor in Visual Studio Code are listed. <br><br>

In the beginning we will see how to create an empty Blazor Server Project Template to work with. To do this, go to your CLI of your choice and run:
```pwsh
dotnet new blazorserver -o <NameOfProject>
```
To create a new Blazor WebAssembly Project, you have to use:
```pwsh
dotnet new blazorwasm -o <NameOfProject>
```
For further informations about creating templates, see the following [documentation](https://docs.microsoft.com/de-de/aspnet/core/blazor/tooling?view=aspnetcore-5.0&pivots=linux). <br><br>

After creating the project template, you could run it or add it to a solution. In a standard way, we add it to a solution first. So you can open it via Visual Studio too. To do this, run the following commands:
```pwsh
dotnet new sln <SolutionFileName>
dotnet sln add <ProjectFolder>\<ProjectName>.csproj
```
Now a new solution (solution-file) is created and we could work with both IDE's. <br>
To see a list of all projects in a solution you could run:
```pwsh
dotnet sln list
```

Next we want to start our newly created application. To do this, change your directory in the project directory and run the following:
```pwsh
cd <ProjectName>\
dotnet watch run
```
This command is a hotfix for quickreloading your application. This feature is just not added to Visual Studio, so a hotreaload is not possible. So you could use this command to simulate exactly the same. <br><br>

If you want to add new Razor-Pages to your Pages-Folder, use this command:
```pwsh
dotnet new razorcomponent -n <RazorPageName> -o Pages
```

## Project Structure
In the following section I'll list the project structure and peek out important parts of it. <br>
The whole project structure is like a normal .NET MVC App so...
```pwsh
│   App.razor
│   appsettings.Development.json
│   appsettings.json
│   HelloWorldBlazorApp.csproj
│   Program.cs (entrypoint for the program)
│   Startup.cs (services and app configurations)
│   _Imports.razor (holds all using statements for the whole project)
│
├───bin (not interesting)
├───Data (not interesting)
├───obj (interesting for deployment)
│   └───Debug
│       └───net5.0
│           ├───Razor
│           │   ├───Pages
│           │   └───Shared
│           ├───RazorDeclaration
│           │   ├───Pages
│           │   └───Shared
│           ├───ref
│           ├───scopedcss
│           │   ├───bundle
│           │   ├───projectbundle
│           │   └───Shared
│           └───staticwebassets
├───Pages (here are all razor pages)
├───Properties
├───Shared (here are shared razor components like NavMenu or Layout)
└───wwwroot (hold the styling properties like css and js)
    └───css
        ├───bootstrap
        └───open-iconic
            └───font
                ├───css
                └───fonts
```
