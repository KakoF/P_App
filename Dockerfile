FROM mcr.microsoft.com/dotnet/sdk:3.1 AS base

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ./PokeApp ./PokeApp
#COPY ["Api.Calculo/Api.Calculo.csproj", "Calculo/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Service/Service.csproj", "Service/"]
COPY ["PokeApp/PokeApp.csproj", "PokeApp/"]
RUN dotnet restore "PokeApp/PokeApp.csproj"
COPY . .
WORKDIR "/src/PokeApp"
RUN dotnet build "PokeApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PokeApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "PokeTrader.Api.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PokeApp.dll
