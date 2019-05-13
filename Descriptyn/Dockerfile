FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Descriptyn/Descriptyn.csproj", "Descriptyn/"]
RUN dotnet restore "Descriptyn/Descriptyn.csproj"
COPY . .
WORKDIR "/src/Descriptyn"
RUN dotnet build "Descriptyn.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Descriptyn.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Descriptyn.dll"]