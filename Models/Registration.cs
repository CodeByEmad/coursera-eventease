using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Registration
{
    [Required(ErrorMessage = "Please enter your full name.")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 80 characters.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select an event.")]
    public int EventId { get; set; }

    public DateTime RegisteredAt { get; set; } = DateTime.Now;
}
