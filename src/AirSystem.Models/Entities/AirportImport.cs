using AirSystem.Models.Entities.Base;
using CsvHelper.Configuration.Attributes;

namespace AirSystem.Models.Entities;

/// <summary>
/// Airport
/// </summary>
public class AirportImport : IHaveCoordinates
{
    [Name("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Airport short  name
    /// </summary>
    [Name("name")]
    public string Name { get; set; }

    /// <summary>
    /// IATA code
    /// </summary>
    [Name("iata_code")]
    public string? IATACode { get; set; }

    /// <summary>
    /// IKAO code
    /// </summary>
    [Name("ident")]
    public string? IKAOCode { get; set; }
    //
    // /// <summary>
    // /// City ID
    // /// </summary>
    // public Guid? CityId { get; set; }
    //
    // /// <summary>
    // /// Country
    // /// </summary>
    // public City? City { get; set; }

    /// <inheritdoc />
    [Name("latitude_deg")]
    public double Latitude { get; set; }

    /// <inheritdoc />
    [Name("longitude_deg")]
    public double Longitude { get; set; }
    //
    // /// <summary>
    // /// Airport's website
    // /// </summary>
    // public string? WebCite { get; set; }
}