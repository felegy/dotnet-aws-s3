#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DotNet.S3/DotNet.S3.csproj", "DotNet.S3/"]
COPY ["DotNet.S3.Common/DotNet.S3.Common.csproj", "DotNet.S3.Common/"]
COPY ["DotNet.S3.Services/DotNet.S3.Services.csproj", "DotNet.S3.Services/"]
RUN dotnet restore "DotNet.S3/DotNet.S3.csproj"
COPY . .
WORKDIR "/src/DotNet.S3"
RUN dotnet build "DotNet.S3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNet.S3.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotNet.S3.dll"]