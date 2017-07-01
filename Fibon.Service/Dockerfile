FROM microsoft/dotnet:runtime

WORKDIR /dotnetapp

Copy./Bin/Docker

ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT["dotnet", "Fibon.Service.dll"]