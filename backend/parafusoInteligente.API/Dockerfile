FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

EXPOSE 80

WORKDIR /app

COPY ./out /app

ENTRYPOINT ["dotnet", "parafusoInteligente.API.dll", "http://0.0.0.0:80"]