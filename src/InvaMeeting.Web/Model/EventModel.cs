using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvaMeetings.Web.Model;

namespace InvaMeetings.Web
{
    [Table("Event")]
    public class EventModel
    {
        [Key]
        public Guid ID{ get; set; }
        [ForeignKey("ID")]


        [Required(ErrorMessage = "Event name is required")]
        [StringLength(15, ErrorMessage = "Name is too long.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Event address is required")]
        public string address { get; set; }
        [Required(ErrorMessage = "Event address is required")]
        public DateTime? date { get; set; }
        [Required(ErrorMessage = "Event description is required")]
        public string description { get; set; }
    
        public EventModel() {
            date = DateTime.Now;
        }

        public ICollection<UserModel> userModels { get; set; }
    }
}
