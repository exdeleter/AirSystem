namespace AirSystem.Abstractions.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IHaveAviaCode
{
    /// <summary>
    /// 
    /// </summary>
    public string ICAOCode { get; set; } 

    /// <summary>
    /// 
    /// </summary>
    public string IATACode { get; set; }
}