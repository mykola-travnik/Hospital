using Domain;

namespace Data
{
    public interface IRepository<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> 
        where TEntity : BaseEntity 
        where TDto : BaseDto, new()
        where TCreateDto : BaseCreateDto, new()
        where TUpdateDto : BaseUpdateDto, new()
        where TQueryDto : BaseQueryDto, new()
    {
        public IQueryable<TEntity> GetQueryable();
        public TDto Get(Guid id);
        public List<TDto> QueryAsync(TQueryDto query);
        public Task<TDto> CreateAsync(TCreateDto item);
        public Task<TDto> UpdateAsync(TUpdateDto item);
        public Task<bool> DeleteAsync(Guid id);
        public Task SeedData(List<TEntity> entities);
    }
}
