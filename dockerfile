FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY ./publish ./
ENTRYPOINT ["dotnet", "OrdersApiAppSPD011.dll"]