using Microsoft.EntityFrameworkCore;

namespace EfCoreMigrationIssue;

public class DemoDbContext(DbContextOptions<DemoDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DemoDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}