using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvaMeetings.Web.Model
{
    [Table("User")]
    public class UserModel
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("Id")]
        public string Email { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Name { get; set; }

        public DateTime? LastLoginDate { get; set; }
    }
}