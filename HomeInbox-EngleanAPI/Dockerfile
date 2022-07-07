#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HomeInbox-EngleanAPI/HomeInbox-EngleanAPI.csproj", "HomeInbox-EngleanAPI/"]
RUN dotnet restore "HomeInbox-EngleanAPI/HomeInbox-EngleanAPI.csproj"
COPY . .
WORKDIR "/src/HomeInbox-EngleanAPI"
RUN dotnet build "HomeInbox-EngleanAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeInbox-EngleanAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeInbox-EngleanAPI.dll"]