using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Airport
/// </summary>
public class Airport : BaseEntity, IHaveCoordinates
{
    /// <summary>
    /// IATA code
    /// </summary>
    public string CodeIATA { get; set; }

    /// <summary>
    /// IKAO code
    /// </summary>
    public string CodeIKAO { get; set; }

    /// <summary>
    /// Airport name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Country ID
    /// </summary>
    public Guid CountryId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public Country Country { get; set; }

    /// <inheritdoc />
    public decimal Latitude { get; set; }

    /// <inheritdoc />
    public decimal Longitude { get; set; }
}