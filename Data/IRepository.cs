using Domain;

namespace Data
{
    public interface IRepository<TEntity, TDto, TCreateDto> 
        where TEntity : BaseEntity 
        where TDto : BaseDto, new()
        where TCreateDto : BaseCreateDto, new()
    {
        public IQueryable<TEntity> GetQueryable();
        public TDto Get(Guid id);
        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
        public Task<TDto> CreateAsync(TCreateDto item);
        public Task<TEntity> UpdateAsync(TEntity item);
        public Task<bool> DeleteAsync(Guid id);
    }
}
