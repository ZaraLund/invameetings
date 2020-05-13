using InvaMeetings.Web.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InvaMeetings.Web.Data
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<EventModel> eventList { get; set; }
        public DbSet<UserModel> userList { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

