using Microsoft.EntityFrameworkCore;
using BAAS.Models;

namespace BAAS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<person> person { get; set; }
        public DbSet<activity_information> activity_information { get; set; }
        public DbSet<exercise_information> exercise_information { get; set; }
        public DbSet<heartrate_information> heartrate_information { get; set; }
        public DbSet<sleep_information> sleep_information { get; set; }
        public DbSet<heartrate_daily> heartrate_daily { get; set; }

    }
}
