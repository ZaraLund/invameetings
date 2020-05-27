using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvaMeetings.Web
{
    [Table("Event")]
    public class EventModel
    {
        [ForeignKey("EventId")]

        [Key]
        public Guid EventId { get; set; }

        [Required(ErrorMessage = "Event name is required")]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Event address is required")]
        public string address { get; set; }

        [Required(ErrorMessage = "Event address is required")]
        public DateTime? date { get; set; }

        [Required(ErrorMessage = "Event description is required")]
        public string description { get; set; }

        public EventModel()
        {
            date = DateTime.Now;
        }

    }
}
