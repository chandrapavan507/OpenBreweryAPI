# OpenBreweryAPI
OpenBreweryAPIASP.NET Core Sample Application



### Prerequisites

In order to build and run the sample OpenBreweryAPIapplication, it is recommended that you have the following installed.

- [.net5.0](https://dotnet.microsoft.com/download). You can test that you have it installed by entering the command `dotnet --list-sdks`
- [Entity Framework Command Line Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet). You can install these as a global tool with the command `dotnet tool install --global dotnet-ef`
- [SQL Server Express](https://docs.microsoft.com/en-us/sql/sql-server/editions-and-components-of-sql-server-version-15?view=sql-server-ver15).
- [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) (Community Edition or Greater) or [Visual Studio Code](https://code.visualstudio.com/)

### Building the Code

You can either load OpenBreweryAPI\OpenBreweryAPI.sln` in Visual Studio 2019 and build from within Visual Studio, or from the command line, in the same folder as `OpenBreweryAPI.sln`, enter the `dotnet build` command.

### Running the Migrations
Before you run OpenBreweryAPIfor the first time, you need to run the database migrations  that have a SQL database.


### Running the Application from Visual Studio 2019
You can run the OpenBreweryAPIapplication directly from within **Visual Studio**. To do this, first right click on project  and view the project properties. 
 

### Running the Application from the Command Line
Alternatively, you can run the OpenBreweryAPIapplication from the command line. You will need to  command prompt for`csproj` file. Navigate into the folder containing the `.csproj` file and run the command `dotnet run`.

**Note:** You may be asked to trust the .NET Core developer certificates. Make sure you do so, in order to use HTTPS to access the services.

### Launch in a browser
If you have followed the instructions, the OpenBreweryAPIclient application (website) will be running on port 44392, which you can access in the browser at [https://localhost:44392](https://localhost:44392).


The API will be running on port 44392 and you can view the API documentation at [https://localhost:44392/swagger](https://localhost:44392/swagger/index.html)
