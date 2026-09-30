using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<Event> _events =
    [
        new Event
        {
            Id = 1,
            Name = "Blazor Community Meetup",
            Date = DateTime.Today.AddDays(7).AddHours(18),
            Location = "Innovation Hub",
            Description = "Learn practical Blazor patterns and connect with other developers.",
            Capacity = 80,
            RegisteredCount = 32
        },
        new Event
        {
            Id = 2,
            Name = "Modern Web Development Workshop",
            Date = DateTime.Today.AddDays(14).AddHours(10),
            Location = "Tech Campus",
            Description = "A hands-on workshop covering modern frontend development techniques.",
            Capacity = 50,
            RegisteredCount = 18
        },
        new Event
        {
            Id = 3,
            Name = "Cloud & .NET Conference",
            Date = DateTime.Today.AddDays(21).AddHours(9),
            Location = "Grand Conference Center",
            Description = "Explore cloud architecture, .NET development, and deployment strategies.",
            Capacity = 120,
            RegisteredCount = 91
        }
    ];

    public IReadOnlyList<Event> GetEvents() => _events;

    public Event? GetEvent(int id) => _events.FirstOrDefault(e => e.Id == id);

    public bool Register(int eventId)
    {
        var selected = GetEvent(eventId);
        if (selected is null || selected.IsFull)
            return false;

        selected.RegisteredCount++;
        return true;
    }
}
