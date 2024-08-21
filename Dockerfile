# Build
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["src/YourCarSlot.Api/YourCarSlot.Api.csproj", "YourCarSlot.Api/"]
COPY ["src/YourCarSlot.Infrastructure/YourCarSlot.Infrastructure.csproj", "YourCarSlot.Infrastructure/"]
COPY ["src/YourCarSlot.Identity/YourCarSlot.Identity.csproj", "YourCarSlot.Identity/"]
COPY ["src/YourCarSlot.Application/YourCarSlot.Application.csproj", "YourCarSlot.Application/"]
COPY ["src/YourCarSlot.Domain/YourCarSlot.Domain.csproj", "YourCarSlot.Domain/"]
COPY ["src/Shared/YourCarSlot.Shared/YourCarSlot.Shared.csproj", "Shared/YourCarSlot.Shared/"]
COPY ["src/Shared/YourCarSlot.Shared.Abstractions/YourCarSlot.Shared.Abstractions.csproj", "Shared/YourCarSlot.Shared.Abstractions/"]

RUN dotnet restore 'YourCarSlot.Api/YourCarSlot.Api.csproj'

WORKDIR "/src/YourCarSlot.Api"
COPY . .
RUN dotnet build "./YourCarSlot.Api.csproj" -c Release -o /app/build

# Publish

FROM build as publish
RUN dotnet publish "./YourCarSlot.Api.csproj" -c Release -o /app/publish


# Run

# FROM mcr.microsoft.com/dotnet/runtime:8.0
FROM base as final
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "YourCarSlot.Api.dll" ]
