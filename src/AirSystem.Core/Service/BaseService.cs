using AirSystem.Abstractions;
using AirSystem.Models.Dtos.Base;
using AirSystem.Models.Entities.Base;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AirSystem.Core.Service;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TDto"></typeparam>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TDbContext"></typeparam>
public class BaseService<TDto, TEntity, TDbContext> : IBaseService<TDto>
    where TEntity : BaseEntity
    where TDto : BaseDto
    where TDbContext : DbContext
{
    private readonly TDbContext _dbContext;
    private readonly ILogger<BaseService<TDto, TEntity, TDbContext>> _logger;
    private readonly IMapper _mapper;

    /// <summary>
    /// Constructor
    /// </summary>
    public BaseService(
        TDbContext dbContext,
        ILogger<BaseService<TDto, TEntity, TDbContext>> logger,
        IMapper mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<List<TDto>> List()
    {
        _logger.LogInformation("Method get for airline controller");

        var dtos = _dbContext.Set<TEntity>();

        return await _mapper.ProjectTo<TDto>(dtos).ToListAsync();
    }

    /// <inheritdoc />
    public async Task<TDto> Get(Guid id)
    {
        var entity = await _dbContext.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id == id);

        if (entity == default)
        {
            return null;
        }

        var dto = _mapper.Map<TDto>(entity);

        await _dbContext.SaveChangesAsync();

        return dto;
    }

    /// <inheritdoc />
    public async Task<TDto> Post(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);

        _dbContext.Add((object)entity);

        await _dbContext.SaveChangesAsync();

        return dto;
    }

    /// <inheritdoc />
    public async Task<TDto> Put(TDto dto)
    {
        var ent = await _dbContext.Set<TEntity>().AnyAsync(x => x.Id == dto.Id);

        if (!ent)
        {
            return null;
        }

        var entity = _mapper.Map<TEntity>(dto);

        _dbContext.Update(entity);

        await _dbContext.SaveChangesAsync();

        return dto;
    }

    /// <inheritdoc />
    public async Task Delete(Guid id)
    {
        var ent = await _dbContext.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id == id);

        if (ent == default)
        {
            throw new Exception("This entity is not exists");
        }

        _dbContext.Remove(ent);

        await _dbContext.SaveChangesAsync();
    }
}