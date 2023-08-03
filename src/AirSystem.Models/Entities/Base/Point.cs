namespace AirSystem.Models.Entities.Base;

public interface IHaveCoordinates
{
    /// <summary>
    /// (10, 6)
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// (10, 6)
    /// </summary>
    public double Longitude { get; set; }
}