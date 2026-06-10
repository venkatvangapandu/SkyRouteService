# AI Prompt Log

## Refactor IAirlineProvider to async
**Prompt:** Refactor IAirlineProvider and implementations to use async methods and CancellationToken.
**AI output:** Updated interface, providers, and service to use async Task methods and added CancellationToken parameters.
**Decision:** Accepted

## Add tests
**Prompt:** Add unit tests for FlightSearchService and providers.
**AI output:** Created xUnit tests in tests/SkyRoute.Api.Tests covering providers and FlightSearchService.
**Decision:** Accepted

## DI and parallelization
**Prompt:** Refactor FlightSearchService to support DI and run providers in parallel.
**AI output:** Introduced IFlightSearchService, constructor injection, and Task.WhenAll aggregation.
**Decision:** Accepted

## README and spec
**Prompt:** Add README.md and spec.md summarizing the project and decisions.
**AI output:** Added both files to repository root.
**Decision:** Accepted


Instructions given to AI tool:
- Follow spec-driven approach: define interfaces first, prefer DI and SOLID, use async and cancellation support, add tests.
