cat << 'EOF' > README.md
# EventEase - Blazor Event Management Application

EventEase is a single-page web application built with **Blazor WebAssembly** that allows users to browse events, edit event titles in real time, register for sessions, and track event attendance.

## Project Features & Rubric Alignment

1. **Event Card Component & Two-Way Data Binding:**
   - Created `EventCard.razor` using `[Parameter]` properties and `@bind` with `@bind:event="oninput"` for live updates.
2. **Routing & Error Handling:**
   - Configured parameterized routing (`/events/{Id:int}`) in `EventDetails.razor`.
   - Added graceful fallback UI for invalid event IDs and customized the `<NotFound>` template in `App.razor`.
3. **Performance Optimization & Validation:**
   - Applied `@key` directives in `Events.razor` loops to optimize DOM diffing and rendering.
   - Implemented `DataAnnotations` (`[Required]`, `[EmailAddress]`, `[StringLength]`) on `EventModel` and `RegistrationModel`.
4. **Advanced Features (State Management & Attendance Tracker):**
   - Built `EventService` as a singleton state container to persist the active user session (`CurrentUser`) and attendee lists across pages.
   - Built an `EditForm` with validation and a real-time Attendance Tracker.

## How Microsoft Copilot Assisted in Development

- **Activity 1 (Code Generation):** Microsoft Copilot generated the initial boilerplate for `EventModel` and `EventCard.razor`, accelerating the setup of Bootstrap card layouts and two-way data binding syntax.
- **Activity 2 (Debugging & Optimization):** Copilot helped diagnose potential `NullReferenceException` issues when navigating to non-existent event IDs and suggested adding `@key` directives to improve list rendering efficiency.
- **Activity 3 (Comprehensive Features):** Copilot assisted in structuring the `EventService` state management pattern, wiring up `EditForm` validation components (`DataAnnotationsValidator`, `ValidationSummary`), and building the dynamic Attendance Tracker UI.
EOF