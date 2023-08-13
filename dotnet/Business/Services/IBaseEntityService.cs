using Domain;

namespace Business.Services;

public interface IBaseEntityService<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto>
    where TEntity : BaseEntity
    where TDto : BaseDto, new()
    where TCreateDto : BaseCreateDto, new()
    where TUpdateDto : BaseUpdateDto, new()
    where TQueryDto : BaseQueryDto, new()
{
    TDto Get(Guid id);
    List<TDto> QueryAsync(TQueryDto query);
    Task<TDto> CreateAsync(TCreateDto item);
    Task<TDto> UpdateAsync(TUpdateDto item);
    Task<bool> DeleteAsync(Guid id);
}