FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Development

COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Erasmus.Web.dll"]
