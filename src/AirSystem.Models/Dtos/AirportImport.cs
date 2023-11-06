using AirSystem.Models.Entities.Base;
using CsvHelper.Configuration.Attributes;

namespace AirSystem.Models.Dtos;

/// <summary>
/// Airport
/// </summary>
public class AirportImport : IHaveCoordinates
{
    /// <summary>
    /// Id
    /// </summary>
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
    public string? ICAOCode { get; set; }

    /// <inheritdoc />
    [Name("latitude_deg")]
    public double Latitude { get; set; }

    /// <inheritdoc />
    [Name("longitude_deg")]
    public double Longitude { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    [Name("country_name")]
    public string CountryName { get; set; }

    /// <summary>
    /// City
    /// </summary>
    [Name("municipality")]
    public string Municipality { get; set; }   
    
    /// <summary>
    /// Website
    /// </summary>
    [Name("home_link")]
    public string Website { get; set; }
}