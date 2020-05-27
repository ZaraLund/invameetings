using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvaMeetings.Web.Model;
using System.Linq;
namespace InvaMeetings.Web.Model
{
    [Table("User")]
    public class UserModel
    {
        [Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public string Email { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Name { get; set; }

        public DateTime? LastLoginDate { get; set; }
    }
}