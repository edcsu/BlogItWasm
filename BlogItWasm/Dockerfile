FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlogItWasm/BlogItWasm.csproj", "BlogItWasm/"]
RUN dotnet restore "BlogItWasm/BlogItWasm.csproj"
COPY . .
WORKDIR "/src/BlogItWasm"
RUN dotnet build "BlogItWasm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlogItWasm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlogItWasm.dll"]
