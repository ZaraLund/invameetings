using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvaMeetings.Web.Model
{
    public class ParticipantModel
    {
        [Key]
        [ForeignKey("[EventId]")]
        public Guid EventId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
