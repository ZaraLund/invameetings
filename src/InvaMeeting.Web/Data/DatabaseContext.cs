using InvaMeetings.Web.Model;
using Microsoft.EntityFrameworkCore;



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

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

