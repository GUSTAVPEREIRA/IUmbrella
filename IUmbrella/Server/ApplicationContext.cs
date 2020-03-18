namespace IUmbrella.Server
{
    using IUmbrella.Server.Model;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {

        public virtual DbSet<User> Clientes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

    }
}
