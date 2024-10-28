namespace EfCoreMigrationIssue;

public class Run(DemoDbContext context)
{

    public void Execute()
    {
        Console.WriteLine("Dropping and creating database...");
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        
        Console.WriteLine("Done");
    }
}