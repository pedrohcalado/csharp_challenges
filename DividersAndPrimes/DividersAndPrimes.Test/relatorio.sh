#!/bin/sh
rm -rf resultados
rm -rf coveragereport
dotnet test --collect:"XPlat Code Coverage" --results-directory:"./resultados/"
folder_guid=$(ls resultados)
path_result="$(pwd)/resultados/${folder_guid}/coverage.cobertura.xml"

#Cria relatorio HTML
reportgenerator "-reports:${path_result}" "-targetdir:coveragereport" -reporttypes:Html
