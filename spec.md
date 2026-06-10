# Spec

## Overview
This document captures the technical specification used to implement the SkyRoute.Api sample project.

## Requirements
- Provide a REST API to search flights and book flights.
- Support multiple providers via IAirlineProvider abstraction.
- Async APIs with CancellationToken support.
- Tests must cover core functionality.

## Key decisions and assumptions
- Providers return a list of flights synchronously simulated and wrapped in Task.FromResult for simplicity.
- FlightSearchService aggregates providers and runs them in parallel using Task.WhenAll.
- DI is used to register providers; multiple providers implement IAirlineProvider.

## Mapping to requirements
- REST API: Controllers/FlightsController.cs implements endpoints /search and /book.
- Providers: Providers/IAirlineProvider.cs, GlobalAirProvider, BudgetWingsProvider.
- Async: SearchFlightsAsync with CancellationToken in providers and service.

## Implementation notes
- FlightSearchService implements IFlightSearchService and supports constructor injection of providers.
- Unit tests in tests/SkyRoute.Api.Tests cover providers and service.

