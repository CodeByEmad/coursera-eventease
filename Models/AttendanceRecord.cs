namespace EventEase.Models;

public class AttendanceRecord
{
    public int EventId { get; set; }
    public string AttendeeName { get; set; } = string.Empty;
    public bool Attended { get; set; }
}
