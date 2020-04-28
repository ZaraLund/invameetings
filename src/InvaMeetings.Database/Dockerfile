FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /src

COPY InvaMeetings.Database.csproj .
RUN dotnet restore InvaMeetings.Database.csproj

COPY . .
RUN find -type d -name bin -prune -exec rm -rf {} \; && find -type d -name obj -prune -exec rm -rf {} \;
RUN dotnet publish InvaMeetings.Database.csproj -c Release -o /app

VOLUME /app/Scripts

WORKDIR /app
ENTRYPOINT ["dotnet", "InvaMeetings.Database.dll"]