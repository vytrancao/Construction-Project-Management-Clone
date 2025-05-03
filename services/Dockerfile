FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /src
ARG SERVICE_NAME
ARG OWNER
ARG PAT_TOKEN

COPY ./${SERVICE_NAME}/Api/Api.csproj ./Api/
COPY ./${SERVICE_NAME}/Application/Application.csproj ./Application/
COPY ./${SERVICE_NAME}/Domain/Domain.csproj ./Domain/
COPY ./${SERVICE_NAME}/Persistence/Persistence.csproj ./Persistence/
COPY ./Common/ ../Common/

RUN dotnet nuget add source --username ${OWNER} --password ${PAT_TOKEN} --store-password-in-clear-text --name github "https://nuget.pkg.github.com/${OWNER}/index.json"
RUN dotnet restore ./Api/Api.csproj
COPY ./${SERVICE_NAME} ./
RUN dotnet build ./Api/Api.csproj -c Debug -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Debug
RUN dotnet publish Api/Api.csproj -c Debug -o /app/publish /p:UseAppHost=false

ENV DOTNET_WATCH_RESTART_ON_CHANGE Always

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]
