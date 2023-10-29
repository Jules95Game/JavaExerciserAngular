using JavaExerciserAngular.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JavaExerciserAngular.DataAccess;

public class DataContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }

    public DataContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}