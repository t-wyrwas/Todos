#build
FROM microsoft/dotnet:sdk AS build-env
WORKDIR /restservice
COPY . ./
RUN dotnet publish -c Release -o out

#runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /restservice
COPY --from=build-env /restservice/Service/out .
ENTRYPOINT ["dotnet", "RestService.dll"]
