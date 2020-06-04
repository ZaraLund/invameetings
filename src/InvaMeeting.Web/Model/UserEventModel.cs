using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvaMeetings.Web.Model
{
    [Table("Event_User")]
    public class UserEventModel
    {
       
        public string UserId { get; set; }
        [Key]
        public Guid EventId { get; set; }
        [ForeignKey("[EventId]")]
        public DateTime ApplicationTime { get; set; }

    }
}
