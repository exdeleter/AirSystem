using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Airport
/// </summary>
public class Airport : BaseEntity, IHaveCoordinates
{
    /// <summary>
    /// Airport short  name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// IATA code
    /// </summary>
    public string? IATACode { get; set; }

    /// <summary>
    /// IKAO code
    /// </summary>
    public string? IKAOCode { get; set; }

    /// <summary>
    /// City ID
    /// </summary>
    public Guid CityId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public City City { get; set; }

    /// <inheritdoc />
    public double Latitude { get; set; }

    /// <inheritdoc />
    public double Longitude { get; set; }
    
    /// <summary>
    /// Airport's website
    /// </summary>
    public string WebCite { get; set; }
}