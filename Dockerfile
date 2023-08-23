# Use a imagem oficial da Microsoft para aplicativos ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

# Imagem para construir a aplicação
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Livraria.csproj", "./"]
RUN dotnet restore "./Livraria.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Livraria.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Livraria.csproj" -c Release -o /app/publish

# Copie os arquivos de publicação para a imagem base
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Livraria.dll"]