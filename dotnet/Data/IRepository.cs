using Domain;

namespace Data
{
    public interface IRepository<TEntity> 
        where TEntity : BaseEntity 
    {
        public IQueryable<TEntity> GetQueryable();
        public TEntity Get(Guid id);
        public Task<TEntity> CreateAsync(TEntity item);
        public Task<TEntity> UpdateAsync(TEntity item);
        public Task<bool> DeleteAsync(Guid id);
    }
}
