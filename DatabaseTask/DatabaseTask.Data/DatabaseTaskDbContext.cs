using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.

        public DbSet<Block> Blocks { get; set; }
        public DbSet<Prison> Prisons { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Inmate> Inmates { get; set; }
        public DbSet<InmateCrime> InmateCrimes { get; set; }
        public DbSet<Crime> Crimes { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Guard> Guards { get; set; }
        public DbSet<GuardShift> GuardShifts { get; set; }
        public DbSet<Shift> Shifts { get; set; }
    }
}
