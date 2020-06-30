#! /bin/bash

set -e

dotnet restore -s /packages
dotnet test ./VideoStore.csproj
