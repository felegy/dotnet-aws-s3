# dotnet-aws-s3


```
│   .dockerignore
│   .editorconfig
│   .gitignore
│   docker-compose.dcproj
│   docker-compose.override.yml
│   docker-compose.yml
│   dotnet-aws-s3.sln
│   global.json
│   README.md
│   stylecop.json
│
├───DotNet.S3.Api
│   │   appsettings.json
│   │   Dockerfile
│   │   DotNet.S3.Api.csproj
│   │   Program.cs
│   │
│   └───Properties
│           launchSettings.json
│
├───DotNet.S3.AppService
│       AppServiceCollectionExtension.cs
│       DotNet.S3.AppService.csproj
│
└───DotNet.S3.Infrastructure
    │   DotNet.S3.Infrastructure.csproj
    │   InfrastructureServiceCollectionExtension.cs
    │
    ├───Configuration
    │       IS3Configuration.cs
    │       S3Configuration.cs
    │
    └───Serilog
        │   LoggingExtensions.cs
        │
        └───Enrichers
                CorrelationIdEnricher.cs
                CorrelationIdHeaderEnricher.cs
```
