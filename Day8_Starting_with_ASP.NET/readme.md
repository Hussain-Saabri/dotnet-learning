# ASP.NET Core Minimal Web App – Using CLI

This project was created with the **minimal/empty** ASP.NET Core web template using the dotnet CLI.

## Command Used

### 1. Create in a new folder (recommended – clean separation)
```bash
dotnet new web -o MyFirstWebApp
cd MyFirstWebApp 

# Make sure you are already inside the desired (preferably empty) folder
dotnet new web -o .
# or simply (same result):
dotnet new web

# Navigate to the project folder (if you used -o MyFirstWebApp)
cd MyFirstWebApp

# Run the app
dotnet run
# or with auto-reload on file changes (recommended during development)
dotnet watch run

MyFirstWebApp/                  (or just your current folder if -o . was used)
├── obj/                        # temporary build files (ignore in git)
├── Properties/
│   └── launchSettings.json     # development ports, launch browser settings
├── appsettings.json
├── appsettings.Development.json
├── MyFirstWebApp.csproj        # project file (like package.json)
└── Program.cs                  # main entry point (like app.js / server.js)