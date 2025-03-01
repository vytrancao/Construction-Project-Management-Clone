FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /src
ARG SERVICE_NAME

COPY ./${SERVICE_NAME}/Api/Api.csproj ./Api/
COPY ./${SERVICE_NAME}/Application/Application.csproj ./Application/
COPY ./${SERVICE_NAME}/Domain/Domain.csproj ./Domain/
COPY ./${SERVICE_NAME}/Persistence/Persistence.csproj ./Persistence/
RUN dotnet restore ./Api/Api.csproj

COPY ./${SERVICE_NAME} ./
WORKDIR /src
RUN dotnet build Api/Api.csproj -c Prod -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish Api/Api.csproj -c Prod -o /app/publish /p:UseAppHost=false

ENV DOTNET_WATCH_RESTART_ON_CHANGE Always
ENV ASPNETCORE_ENVIRONMENT=Production

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_HTTP_PORTS=8000
ENTRYPOINT ["dotnet", "Api.dll"]
