using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvaMeetings.Web
{
    [Table("Event")]
    public class EventModel
    {
        
        public Guid ID{ get; set; }
        [Key]
        [ForeignKey("ID")]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public DateTime? date { get; set; }
        [Required]
        public string description { get; set; }
    
        public EventModel() {
            date = DateTime.Now;
        }
    }
}
