namespace BlazingTrails.Api.Data;

public class BlazingTrailsContextInitializer
{
    private readonly BlazingTrailsContext _context;

    public BlazingTrailsContextInitializer(BlazingTrailsContext context)
    {
        _context = context;
    }

    public void Initialize()
    {
        _context.Database.EnsureCreated();
    }
}
