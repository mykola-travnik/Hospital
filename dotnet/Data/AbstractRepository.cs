using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data;

public abstract class AbstractRepository<TEntity> : IRepository<TEntity>
    where TEntity : BaseEntity

{
    private readonly DbContext _context;


    protected AbstractRepository(DbContext context)
    {
        _context = context;
    }

    public IQueryable<TEntity> GetQueryable()
    {
        return _context.Set<TEntity>().AsQueryable();
    }

    TEntity IRepository<TEntity>.Get(Guid id)
    {
        var entity = GetQueryable().FirstOrDefault(entity => entity.Id == id);

        if (entity == null) throw new Exception("Not Found");

        return entity;
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        var dataTime = DateTime.Now.ToUniversalTime();

        entity.CreationTimestamp = dataTime;
        entity.ModifiedTimestamp = dataTime;
        entity.IsDeleted = false;
        entity.Id = Guid.NewGuid();

        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<List<TEntity>> CreateOrUpdateRangeAsync(List<TEntity> entities)
    {
        var dataTime = DateTime.Now.ToUniversalTime();

        entities.ForEach(async entity =>
        {
            var existEntity = _context.Set<TEntity>().FirstOrDefault(item => item.Id == entity.Id);

            if (existEntity != default)
            {
                _context.Entry(existEntity).CurrentValues.SetValues(entity);
                _context.Set<TEntity>().Update(existEntity);
            }
            else
            {
                await _context.Set<TEntity>().AddAsync(entity);
            }
        });

        await _context.SaveChangesAsync();

        return entities;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entityExsist = GetQueryable().AsNoTracking().Any(updateEntity => updateEntity.Id == entity.Id);

        if (!entityExsist) throw new Exception("Not Found");

        entity.ModifiedTimestamp = DateTime.Now.ToUniversalTime();

        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity = GetQueryable().AsNoTracking().FirstOrDefault(updateEntity => updateEntity.Id == id);

        if (entity == default) throw new Exception("Not Found");

        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();

        return true;
    }
}