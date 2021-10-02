FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
COPY . .
RUN dotnet publish -c Release SamplesServer.sln -o out
# image

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
# standard entrypoint not used when host on Heroku
# ENTRYPOINT [ "dotnet", "SamplesServer.dll" ]
# We will use this one with parametrized PORT
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet SamplesServer.dll
EXPOSE 8000
CMD ["dotnet", "SamplesServer.dll"]