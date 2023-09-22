using Microsoft.EntityFrameworkCore;

namespace ISM_IncLookup
{
    public class ISM_DB : DbContext
    {
        public ISM_DB(DbContextOptions<ISM_DB> options)
            : base(options)
        {
        }

        // Define your database tables here as DbSet properties
        public DbSet<Incident> Incidents { get; set; }
        // Add more DbSet properties for other tables if needed

        // Configure database relationships, constraints, and more here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your database schema here
        }
    }
}
