[Razor Pages with Entity Framework Core in ASP.NET Core - Tutorial 1 of 8](https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio-code)




## Prerequisites
If you're new to Razor Pages, go through the [Get started with Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0) tutorial series before starting this one.

## Create the web app project
```


```
## Set up the site style


## The data model
```
ni -Type File .\Models\Student.cs -Force
ni -Type File .\Models\Enrollment.cs -Force
ni -Type File .\Models\Course.cs -Force

```


## The Student entity

## The Enrollment entity

## The Course entity

## Scaffold Student pages

```
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore


dotnet tool install --global dotnet-aspnet-codegenerator

dotnet aspnet-codegenerator razorpage -m Student -dc ContosoUniversity.Data.SchoolContext -udl -outDir Pages\Students --referenceScriptLibraries -sqlite

```


## Database connection string

## Update the database context class
Program.cs

## Create the database

## Seed the database

## View the database


## Asynchronous EF methods in ASP.NET Core web apps


## Performance considerations


## Next steps


## Referrences

```
dotnet ef migrations add InitialCreate
# dotnet ef migrations remove # To undo
dotnet ef database update
```

