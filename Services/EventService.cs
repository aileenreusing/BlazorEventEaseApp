using BlazorEventEaseApp.Models;

namespace BlazorEventEaseApp.Services
{
    public class EventService
    {
        public List<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Annual Tech Conference",
                    Date = new DateTime(2025, 7, 10),
                    Location = "New York",
                    Description = "A conference about the latest in tech."
                },
                new Event
                {
                    Id = 2,
                    Name = "Marketing Meetup",
                    Date = new DateTime(2025, 8, 22),
                    Location = "San Francisco",
                    Description = "Networking event for marketing professionals."
                },
                new Event
                {
                    Id = 3,
                    Name = "Innovation Summit",
                    Date = new DateTime(2025, 9, 15),
                    Location = "Chicago",
                    Description = "Explore groundbreaking ideas in business and tech."
                }
            };
        }

        public Event? GetEventById(int id)
        {
            return GetEvents().FirstOrDefault(e => e.Id == id);
        }
    }
}
