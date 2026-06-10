# SkyRoute.Api

## Introduction
- SkyRoute.Api is a sample flight search and booking backend.
- Implemented spec-driven: interface-first for providers, async APIs with CancellationToken, and tests added before some refactors.

## AI tooling
- Tool: GitHub Copilot (this session) using an internal code-generation agent.
- Model: internal coding agent (session-managed). Used to refactor code, add async APIs, and generate tests and docs.

## Architecture diagram
- Layers:
  API (Controllers)
	-> Services (FlightSearchService, BookingService)
	  -> Providers (IAirlineProvider implementations)
		-> Models

  [API]
	|
	v
  [Services] <-- DI
	|
	v
  [Providers]

## Project structure
- SkyRoute.Api/
  - Controllers/
  - Models/
  - Providers/
  - Services/
  - Properties/
  - tests/

## Tech stack
- Language: C#
- Framework: .NET 10 (net10.0)
- Test library: xUnit 2.5.3, Microsoft.NET.Test.Sdk 18.2.0

## API reference
- Swagger UI (local): https://localhost:44382/swagger/index.html

## How to run locally
Prerequisites:
- .NET 10 SDK installed

Commands:
- Build backend: dotnet build
- Run backend: dotnet run
- Run tests: dotnet test tests/SkyRoute.Api.Tests

Frontend:
- No frontend is included. If you add an Angular app, run: ng build

## Notes
- Services are registered with DI. FlightSearchService runs provider calls in parallel and respects CancellationToken.
