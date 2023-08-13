using AutoMapper;
using Data;
using Domain;

namespace Business.Services;

public abstract class
    BaseEntityService<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> : IBaseEntityService<TEntity, TDto, TCreateDto,
        TUpdateDto, TQueryDto>
    where TEntity : BaseEntity
    where TDto : BaseDto, new()
    where TCreateDto : BaseCreateDto, new()
    where TUpdateDto : BaseUpdateDto, new()
    where TQueryDto : BaseQueryDto, new()
{
    private readonly IMapper mapper;
    private readonly IRepository<TEntity> repository;

    public BaseEntityService(IRepository<TEntity> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<TDto> CreateAsync(TCreateDto dto)
    {
        var entity = mapper.Map<TCreateDto, TEntity>(dto);
        var newEntity = await repository.CreateAsync(entity);

        var newDto = mapper.Map<TEntity, TDto>(newEntity);

        return newDto;
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        return repository.DeleteAsync(id);
    }

    public TDto Get(Guid id)
    {
        var entity = repository.Get(id);
        var dto = mapper.Map<TEntity, TDto>(entity);

        return dto;
    }

    public async Task<TDto> UpdateAsync(TUpdateDto updateDto)
    {
        var updateEntity = GetQueryable().FirstOrDefault(updateEntity => updateEntity.Id == updateDto.Id);

        if (updateEntity == null) throw new Exception("Not Found");

        updateEntity = mapper.Map(updateDto, updateEntity);

        var entity = await repository.UpdateAsync(updateEntity);

        return mapper.Map<TEntity, TDto>(entity);
    }

    public List<TDto> QueryAsync(TQueryDto query)
    {
        throw new NotImplementedException();
    }

    protected List<TDto> Find(Func<TEntity, bool> predicate)
    {
        var result = GetQueryable().Where(predicate).ToList();

        if (!result.Any())
            return new List<TDto>();

        return result.Select(item => mapper.Map<TEntity, TDto>(item)).ToList();
    }

    public IQueryable<TEntity> GetQueryable()
    {
        return repository.GetQueryable();
    }


    ///// <summary>
    ///// Для сидинга данных
    ///// </summary>
    ///// <param name="entity">Сущность для записи</param>
    //public async Task SeedData(List<TEntity> entities)
    //{
    //    entities.ForEach(async entity =>
    //    {
    //        if (entity == null) { throw new Exception("Not Found"); }

    //        var updateEntity = GetQueryable().AsNoTracking().FirstOrDefault(updateEntity => updateEntity.Id == entity.Id);

    //        if (updateEntity == default)
    //            await _context.Set<TEntity>().AddAsync(entity);
    //        else
    //            _context.Set<TEntity>().Update(entity);
    //    });

    //    await _context.SaveChangesAsync();
    //}
}