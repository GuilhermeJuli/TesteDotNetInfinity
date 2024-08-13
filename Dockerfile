# Imagem base para o runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Imagem base para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o arquivo .csproj e restaura as dependências
COPY ["TesteDotNetInfinity.csproj", "."]
RUN dotnet restore "TesteDotNetInfinity.csproj"

# Copia o restante do código e compila
COPY . .
RUN dotnet build "TesteDotNetInfinity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TesteDotNetInfinity.csproj" -c Release -o /app/publish

# Imagem final para execução
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TesteDotNetInfinity.dll"]
