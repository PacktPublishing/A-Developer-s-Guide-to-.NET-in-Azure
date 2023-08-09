FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY *.csproj ./source/
WORKDIR /source
RUN dotnet restore --no-cache
COPY . .
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "WeatherforecastApi.dll"]