# ─────────────────────────────────────────────────────────────────
# Stage 1 – BUILD
# Use the official .NET 6 SDK image to compile the application
# ─────────────────────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set working directory inside the container
WORKDIR /app

# Copy project file and restore NuGet packages (layer-cached)
COPY SmartResultPredictor.csproj ./
RUN dotnet restore

# Copy all source files
COPY . ./

# Publish a self-contained, Release build
RUN dotnet publish SmartResultPredictor.csproj \
    -c Release \
    -o /app/publish \
    --no-restore

# ─────────────────────────────────────────────────────────────────
# Stage 2 – RUNTIME
# Use the smaller ASP.NET runtime image
# NOTE: Windows Forms requires a Windows container for actual GUI.
#       For Docker (Linux), we run in headless / console mode.
#       Swap base image to mcr.microsoft.com/dotnet/framework/runtime:4.8
#       on Windows Docker for full WinForms support.
# ─────────────────────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish ./

# Expose port (optional – useful if a REST endpoint is added later)
EXPOSE 80

# Set entry point: run the compiled executable
ENTRYPOINT ["dotnet", "SmartResultPredictor.dll"]
