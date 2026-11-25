using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event name is required.")]
        [StringLength(100, ErrorMessage = "Event name cannot exceed 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Event date is required.")]
        public DateTime Date { get; set; } = DateTime.Now.AddDays(7);

        [Required(ErrorMessage = "Event location is required.")]
        public string Location { get; set; } = string.Empty;

        public List<RegistrationModel> Attendees { get; set; } = new();
    }

    public class RegistrationModel
    {
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(60, ErrorMessage = "Name is too long.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string UserEmail { get; set; } = string.Empty;
    }
}
