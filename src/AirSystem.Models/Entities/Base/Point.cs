namespace AirSystem.Models.Entities.Base;

public interface IHaveCoordinates
{
    /// <summary>
    /// (10, 6)
    /// </summary>
    public decimal Latitude { get; set; }

    /// <summary>
    /// (10, 6)
    /// </summary>
    public decimal Longitude { get; set; }
}