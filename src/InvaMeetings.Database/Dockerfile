FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /src

COPY InvaMeetings.Database.csproj .
RUN dotnet restore InvaMeetings.Database.csproj

COPY . .
RUN dotnet publish InvaMeetings.Database.csproj -c Release -o /app

VOLUME /app/Scripts

WORKDIR /app
ENTRYPOINT ["dotnet", "InvaMeetings.Database.dll"]