namespace BlazingTrails.Api.Data;

public class BlazingTrailsContext : DbContext
{
    public BlazingTrailsContext(DbContextOptions<BlazingTrailsContext> options) : base(options)
    {
    }

    public DbSet<Trail> Trails => Set<Trail>();

    public DbSet<RouteInstruction> RouteInstructions => Set<RouteInstruction>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlazingTrailsContext).Assembly);
    }
}
