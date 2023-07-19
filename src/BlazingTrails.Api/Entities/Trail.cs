namespace BlazingTrails.Api.Entities;

public class Trail
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    public int Length { get; set; }

    public int TimeInMinutes { get; set; }

    public TimeSpan Duration => TimeSpan.FromMinutes(TimeInMinutes);

    public IEnumerable<RouteInstruction> Routes { get; set; } = Enumerable.Empty<RouteInstruction>();
}
