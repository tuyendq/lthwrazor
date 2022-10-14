[Tutorial: Get started with Razor Pages in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start)






```
# Create a Razor Pages web app.
dotnet new webapp -o RazorPagesMovie
# Run VS Code
code -r .\RazorPagesMovie\
# Create README.md file
ni -Type File README.md

# first run to check
dotnet run

# Or keep monitoring changes
dotnet watch run

# Add a data model Movie
ni -Type File .\Models\Movie.cs -Force


# Scaffold the Movie model
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet-aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite

```