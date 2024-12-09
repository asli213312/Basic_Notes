FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Basic_Notes/Basic_Notes.csproj", "Basic_Notes/"]
RUN dotnet restore "Basic_Notes/Basic_Notes.csproj"
COPY . .
WORKDIR "/src/Basic_Notes"
RUN dotnet build "Basic_Notes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Basic_Notes.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Basic_Notes.dll"]
