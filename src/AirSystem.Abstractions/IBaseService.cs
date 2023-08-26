namespace AirSystem.Abstractions;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TDto"></typeparam>
public interface IBaseService<TDto>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Task<List<TDto>> List();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Task<TDto> Get(Guid id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public Task<TDto> Post(TDto dto);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public Task<TDto> Put(TDto dto);

    /// <summary>
    /// Delete entity
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Task Delete(Guid id);
}