using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Manufacturer
/// </summary>
public class Manufacturer : BaseEntity
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
}