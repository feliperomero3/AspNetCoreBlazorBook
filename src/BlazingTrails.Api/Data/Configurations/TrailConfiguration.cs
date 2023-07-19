using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazingTrails.Api.Data.Configurations;

public class TrailConfiguration : IEntityTypeConfiguration<Trail>
{
    public void Configure(EntityTypeBuilder<Trail> builder)
    {
        builder.ToTable("Trails");

        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.Location);

        builder.Property(x => x.Name)
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(x => x.Location)
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(x => x.Image)
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(x => x.Length)
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(x => x.TimeInMinutes)
            .HasMaxLength(60 * 72)
            .IsRequired();
    }
}
