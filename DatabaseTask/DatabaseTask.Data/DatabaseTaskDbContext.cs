using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Intranet> Intranets { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Borrows> Borrows { get; set; }
        public DbSet<Items_owned_by_company> Items_owned_by_company { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<HealthCare> HealthCares { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Määra Employee ja Costumer vaheline 1:1 seos
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Costumer)
                .WithOne(c => c.Employee)
                .HasForeignKey<Costumer>(c => c.Employee_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}