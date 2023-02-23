#!/bin/bash
projects=(*.UnitTests *.IntegrationTests)
for project in ${projects[*]}
do
        echo Running tests for: $project
        dotnet test tests/$project/$project.csproj
done