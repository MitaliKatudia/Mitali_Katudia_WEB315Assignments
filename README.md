# Mitali_Katudia_WEB315Assignments
 
 Created a webApp project with name 'TheUnoBooks'.
 Terminal command - dotnet new webapp -o TheUnoBooks
 Tried dotnet run without giving the cd command and had errors, then after the command the build succeeded.
 Ran the program and to secure it, terminal command - dotnet dev-certs https --trust
 I allowed c# extension which created a different folder and when I fetched on github there were error so i deleted the folder again and it worked
 Edited the welcome page, added my name and the current date time  

To add a model - 
Added a folder name Models with another file named Book.cs and added class Book with 6 properties 
Added terminal commands - dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*
When entered the above command, it added the packages in the .csproj file 

For Scaffolding - 
entered the command 'dotnet-aspnet-codegenerator razorpage -m Book -dc TheUnoBooksContext -udl -outDir Pages/Books --referenceScriptLibraries -sqlite' in the terminal and it built the project with adding the edit, delete, create pages in the books folder
Did the necessary syntax changes in the startup.cs file  

For the Database using Migration feature, when entered the terminal command - dotnet ef migrations add InitialCreate
dotnet ef database update - it created a new Migrations folder.
Entered a book entry inside the https://localhost:5001/Books link,
added "Microsoft.EntityFrameworkCore.Database.Command": "Information" in the appsettings.Development.json file 

There was error in the index.cshtml.cs file at line 16 and 17. An assembly reference was missing which meant the namespace was missing in the  TheUnoBooksContext.cs file in the Data folder. Had to add namespace TheUnoBooks.Data and then add the using TheUnoBooks.Data; in every file which was using the database.

Seeding the Data - 
Created a file named SeedData in the Models folder and did the changes. Added Data content in the syntax
Replaced content of Program.cs and changed the namespace names.  
