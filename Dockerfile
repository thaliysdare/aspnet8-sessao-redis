FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["aspnet8-sessao-redis.csproj", "./"]
RUN dotnet restore "aspnet8-sessao-redis.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "aspnet8-sessao-redis.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "aspnet8-sessao-redis.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "aspnet8-sessao-redis.dll"]
