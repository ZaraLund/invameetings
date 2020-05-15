using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvaMeetings.Web.Model
{
    [Table("Event_User")]
    public class UserEventModel
    {
        [Key]
        public string UserId { get; set; }
        [ForeignKey("[UserId]")]
        public Guid EventId { get; set; }
        public DateTime ApplicationTime { get; set; }
  
    }
}
 