using InvaMeetings.Web.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace InvaMeetings.Web.Data
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<EventModel> eventList { get; set; }
        public DbSet<UserModel> userList { get; set; }
        public DbSet<UserEventModel> userEventModelList { get; set; }
        public DbSet<ParticipantModel> participantList { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

