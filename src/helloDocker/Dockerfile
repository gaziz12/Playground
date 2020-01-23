FROM mcr.microsoft.com/dotnet/core/runtime:3.0
WORKDIR /app

COPY ${GITHUB_WORKSPACE}/src/helloDocker/app/bin/Release/netcoreapp3.0/publish/ app/
ENTRYPOINT ["dotnet", "app/dockerConsole.dll"]
