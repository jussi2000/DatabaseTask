using Microsoft.EntityFrameworkCore;
using DatabaseTask.Core.Domain;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Bookable> Bookables { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}