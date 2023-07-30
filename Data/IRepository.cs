using Domain;

namespace Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity Get(Guid id);
        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
        public Task<TEntity> CreateAsync(TEntity item);
        public Task<TEntity> UpdateAsync(TEntity item);
        public Task<bool> DeleteAsync(Guid id);
    }
}
