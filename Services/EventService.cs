using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public string? CurrentUser { get; set; }

        public List<EventModel> Events { get; private set; } = new()
        {
            new EventModel
            {
                Id = 1,
                Name = "Global Tech Summit 2026",
                Date = DateTime.Now.AddDays(14),
                Location = "Grand Convention Center"
            },
            new EventModel
            {
                Id = 2,
                Name = "Blazor & Copilot Workshop",
                Date = DateTime.Now.AddDays(21),
                Location = "Innovation Hub, Room 302"
            },
            new EventModel
            {
                Id = 3,
                Name = "Annual Developers Meetup",
                Date = DateTime.Now.AddDays(30),
                Location = "Downtown Tech Lounge"
            }
        };

        public EventModel? GetEventById(int id)
        {
            return Events.FirstOrDefault(e => e.Id == id);
        }

        public void RegisterUser(int eventId, RegistrationModel registration)
        {
            var targetEvent = GetEventById(eventId);
            if (targetEvent != null)
            {
                targetEvent.Attendees.Add(registration);
                CurrentUser = registration.UserName;
            }
        }
    }
}
