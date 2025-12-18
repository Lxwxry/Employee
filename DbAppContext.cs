using Microsoft.EntityFrameworkCore;

public class DbAppContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=your_db;Username=postgres;Password=1234"
        );
    }
}
