namespace IUmbrella.Server
{
    using IUmbrella.Shared.Model;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {

        public DbSet<User> Users{ get; set; }
        public DbSet<Permission> Permissions{ get; set; }
        public DbSet<Professional> Professional{ get; set; }

        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(t => t.Id);
            modelBuilder.Entity<Permission>().HasKey(t => t.Id);


        }

    }
}
