namespace BlazingTrails.Api.Entities;

public class RouteInstruction
{
    public int Id { get; set; }

    public int Stage { get; set; }

    public string Description { get; set; } = string.Empty;

    public Trail Trail { get; set; } = null!;
}