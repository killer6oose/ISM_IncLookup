using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ISM_IncLookup
{
    public class ISM_DB : DbContext
    {
        private readonly IConfiguration _configuration;

        public ISM_DB(DbContextOptions<ISM_DB> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Access the connection string from appsettings.json
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            
            // Use the connection string to configure the database context
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Define the DbSet property for the Incident table
        public DbSet<Incident> Incidents { get; set; }

        // No need to define DbSet properties for other tables if not needed

        // Configure database relationships, constraints, and more here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your database schema here
        }
    }
}
