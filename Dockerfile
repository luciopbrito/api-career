# Stage 1: Build the app using the SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copy the rest of the application code
COPY . .

# Copy the .csproj and restore dependencies
RUN dotnet restore

# Publish the application
RUN dotnet publish src/ApiCareer.Api/ApiCareer.Api.csproj -c Release -o /app/publish

# Stage 2: Use the ASP.NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

# Copy the published app from the build stage
COPY --from=build /app/publish .

CMD ["dotnet", "ApiCareer.Api.dll", "--no-launch-profile"]