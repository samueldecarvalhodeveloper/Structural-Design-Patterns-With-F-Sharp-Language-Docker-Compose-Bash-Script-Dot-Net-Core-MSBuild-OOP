FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /src/app/

COPY ./StructuralDesignPatterns.sln /src/app/StructuralDesignPatterns.sln
COPY ./StructuralDesignPatterns.fsproj /src/app/StructuralDesignPatterns.fsproj
COPY ./Program.fs /src/app/Program.fs
COPY ./Src/ /src/app/Src/

RUN dotnet publish -c Release -o /src/app/publish/

CMD dotnet /src/app/publish/StructuralDesignPatterns.dll
