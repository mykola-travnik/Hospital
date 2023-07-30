﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public abstract class AbstractRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext _context;

        protected AbstractRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity Get(Guid id)
        {
            return _context.Set<TEntity>().FirstOrDefault(_ => _.Id == id);
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
            var entity = Get(id);

            if (entity is null)
                return false;

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
