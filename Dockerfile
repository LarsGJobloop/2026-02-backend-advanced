# Step-by-step recipe

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
# Change "cd /app" into the /app directory
WORKDIR /App

# Copy everything
COPY . /App
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish --output out src/MemoryService

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0
# Change "cd /app" into the /app directory
WORKDIR /App

# Copy from the build stage in this stage
COPY --from=build /App/out /App

# Setup what should happen when running the container
ENTRYPOINT ["dotnet", "MemoryService.dll"]
