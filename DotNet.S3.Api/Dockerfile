FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DotNet.S3.Api/DotNet.S3.Api.csproj", "DotNet.S3.Api/"]
COPY ["DotNet.S3.Infrastructure/DotNet.S3.Infrastructure.csproj", "DotNet.S3.Infrastructure/"]
COPY ["DotNet.S3.AppService/DotNet.S3.AppService.csproj", "DotNet.S3.AppService/"]
RUN dotnet restore "DotNet.S3.Api/DotNet.S3.Api.csproj"
COPY . .
WORKDIR "/src/DotNet.S3.Api"
RUN dotnet build "DotNet.S3.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNet.S3.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotNet.S3.Api.dll"]
