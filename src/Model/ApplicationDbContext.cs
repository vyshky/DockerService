using Microsoft.EntityFrameworkCore;
using OrdersApiAppSPD011.Model.Entity;

namespace CloudDbTestSPD011.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }

        // конфигурация контекста
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
