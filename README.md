# EventEase

EventEase is a Blazor Web App demonstrating event browsing, routing, registration validation, session state, and attendance tracking.

## Features

- Reusable Event Card component
- Event fields: name, date, location, description, capacity, availability
- Blazor data binding for search and registration fields
- Routing for home, events, event details, registration, and attendance
- Registration form with DataAnnotations validation
- Session state service for the current registered user
- Attendance tracker with attendance state
- Search/filtering for events
- Friendly handling of missing routes and missing events

## How the project addresses the assignment rubric

### 1. GitHub repository
The project is intended to be placed in a public GitHub repository.

### 2. Event Card and two-way binding
The reusable `EventCard.razor` component receives event data through a component parameter. The events page uses Blazor binding for the search input, and the registration form uses two-way binding with `@bind-Value`.

### 3. Routing
The application uses Blazor routing with routes for `/`, `/events`, `/events/{id}`, `/register`, `/register/{eventId}`, and `/attendance`. A NotFound view handles invalid routes.

### 4. Performance and debugging
The application keeps the sample data in a lightweight service, filters events locally, avoids unnecessary network calls, validates user input before submission, and handles missing event IDs and full events.

### 5. Advanced features
The application includes a validated registration form, a scoped session state service, and an attendance tracker that can mark the current session attendee as attended.

## Copilot assistance summary

Microsoft Copilot can be documented as part of each development stage:

1. **Foundation:** Copilot was used to generate the initial Event Card structure, event fields, component parameters, and Blazor binding patterns.
2. **Routing:** Copilot assisted with creating page routes and diagnosing navigation/routing issues.
3. **Debugging and optimization:** Copilot was used to review validation, null handling, component state, and inefficient patterns and suggest corrections.
4. **Advanced features:** Copilot assisted with the registration form, DataAnnotations validation, session state management, and attendance tracking.
5. **Final review:** Copilot was used to review the project structure and identify areas that could be simplified or improved before submission.

> Note: The repository should only claim Copilot usage that accurately reflects the work performed during development. If the course requires screenshots or chat history as evidence, retain those separately.

## Running the project

1. Install the .NET 9 SDK.
2. Open `EventEase.sln` if a solution file is created, or open `EventEase.csproj` directly in Visual Studio 2022.
3. Restore dependencies.
4. Build the project.
5. Run with Visual Studio.
