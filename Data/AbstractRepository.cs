using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public abstract class AbstractRepository<TEntity, TDto> : IRepository<TEntity, TDto> where TEntity : BaseEntity where TDto : BaseDto, new()
    {
        private readonly DbContext _context;
        private readonly IMapper mapper;

        protected AbstractRepository(DbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public TDto Get(Guid id)
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(_ => _.Id == id);

            if (entity == null) { throw new Exception("Not Found"); }

            var dto = mapper.Map<TEntity, TDto>(entity);

            //dto.Id = entity.Id;
            //dto.IsDeleted = entity.IsDeleted;
            //dto.CreationTimestamp = entity.CreationTimestamp;
            //dto.ModifiedTimestamp = entity.ModifiedTimestamp;
            //dto.DeletedTimestamp = entity.DeletedTimestamp;

            return dto;
        }

        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate)
        {
            return new(() => _context.Set<TEntity>().Where(predicate));
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = GetQueryable().FirstOrDefault(entity => entity.Id == id);

            if (entity is null)
                return false;

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
