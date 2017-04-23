clean-run: cleanup restore run
test: cleanup restore test-projs

cleanup:
	dotnet clean src/ScoreService.API
	dotnet clean test/ScoreService.Tests
	dotnet clean test/ScoreService.IntegrationTests

restore:
	dotnet restore src/ScoreService.API
	dotnet restore test/ScoreService.Tests
	dotnet restore test/ScoreService.IntegrationTests

build:
	dotnet build src/ScoreService.API
	dotnet build test/ScoreService.Tests
	dotnet build test/ScoreService.IntegrationTests

run:
	dotnet run -p src/ScoreService.API/ScoreService.API.csproj

test-projs:
	dotnet test test/ScoreService.Tests/ScoreService.Tests.csproj
	dotnet test test/ScoreService.IntegrationTests/ScoreService.IntegrationTests.csproj