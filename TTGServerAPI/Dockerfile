#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TTGServerAPI/InfoService.csproj", "TTGServerAPI/"]
RUN dotnet restore "TTGServerAPI/InfoService.csproj"
COPY . .
WORKDIR "/src/TTGServerAPI"
RUN dotnet build "InfoService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InfoService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InfoService.dll"]