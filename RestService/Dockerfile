#build
FROM microsoft/dotnet:sdk AS build-env
WORKDIR /restservice
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

#runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /restservice
COPY --from=build-env /restservice/out .
ENTRYPOINT ["dotnet", "RestService.dll"]
