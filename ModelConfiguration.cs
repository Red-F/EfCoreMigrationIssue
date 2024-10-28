using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreMigrationIssue;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("DemoDb");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Uids).HasField("_uids");
    }
}