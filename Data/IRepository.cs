using Domain;

namespace Data
{
    public interface IRepository<TEntity, TDto> where TEntity : BaseEntity where TDto : BaseDto, new()
    {
        public IQueryable<TEntity> GetQueryable();
        public TDto Get(Guid id);
        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
        public Task<TEntity> CreateAsync(TEntity item);
        public Task<TEntity> UpdateAsync(TEntity item);
        public Task<bool> DeleteAsync(Guid id);
    }
}
