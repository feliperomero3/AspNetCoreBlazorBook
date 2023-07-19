using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazingTrails.Api.Data.Configurations;

public class RouteInstructionConfiguration : IEntityTypeConfiguration<RouteInstruction>
{
    public void Configure(EntityTypeBuilder<RouteInstruction> builder)
    {
        builder.ToTable("RouteInstructions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Stage)
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(256)
            .IsRequired();

        builder.HasOne(x => x.Trail)
            .WithMany(x => x.Routes)
            .HasForeignKey("TrailId") // Shadow property
            .IsRequired();
    }
}
