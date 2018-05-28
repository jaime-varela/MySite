FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app
# Copy everything else and build
COPY . ./
RUN dotnet restore
RUN dotnet publish JaimeVarela/JaimeVarela.csproj -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/JaimeVarela/out .
ENTRYPOINT ["dotnet", "JaimeVarela.dll"]