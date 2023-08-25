using Microsoft.EntityFrameworkCore;

namespace RegOffice.DataServiceCore
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=loc;Port=5432;Database=usersdb;Username=postgres;Password=пароль_от_postgres");
        }
    }
}