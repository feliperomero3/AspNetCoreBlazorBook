namespace BlazingTrails.Client.Models;

/// <summary>
/// Represent a way-point on the route to help guide other walkers.
/// </summary>
public class RouteInstruction
{
    public int Stage { get; set; }

    public string Description { get; set; } = string.Empty;
}
