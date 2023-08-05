﻿using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public abstract class AbstractRepository<TEntity, TDto, TCreateDto, TUpdateDto> : IRepository<TEntity, TDto, TCreateDto, TUpdateDto> 
        where TEntity : BaseEntity
        where TDto : BaseDto, new()
        where TCreateDto : BaseCreateDto, new()
        where TUpdateDto : BaseUpdateDto, new()

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
            var entity = GetQueryable().FirstOrDefault(entity => entity.Id == id);

            if (entity == null) { throw new Exception("Not Found"); }

            var dto = mapper.Map<TEntity, TDto>(entity);

            return dto;
        }

        public Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate)
        {
            return new(() => _context.Set<TEntity>().Where(predicate));
        }

        public async Task<TDto> CreateAsync(TCreateDto entity)
        {
            var newEntity = mapper.Map<TCreateDto, TEntity>(entity);
            var dataTime = DateTime.Now.ToUniversalTime();

            newEntity.CreationTimestamp = dataTime;
            newEntity.ModifiedTimestamp = dataTime;
            newEntity.IsDeleted = false;
            newEntity.Id = Guid.NewGuid();

            await _context.Set<TEntity>().AddAsync(newEntity);
            await _context.SaveChangesAsync();

            var dto = mapper.Map<TEntity, TDto> (newEntity);

            return dto;
        }

        public async Task<TDto> UpdateAsync(TUpdateDto entity)
        {
            var updateEntity = GetQueryable().FirstOrDefault(updateEntity => updateEntity.Id == entity.Id);

            if (entity == null) { throw new Exception("Not Found"); }

            var dataTime = DateTime.Now.ToUniversalTime();

            updateEntity.ModifiedTimestamp = dataTime;
            updateEntity = mapper.Map<TUpdateDto, TEntity>(entity);////////////

            _context.Set<TEntity>().Update(updateEntity);
            await _context.SaveChangesAsync();

            var dto = mapper.Map<TEntity, TDto> (updateEntity);

            return dto;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = GetQueryable().FirstOrDefault(entity => entity.Id == id);
           
            if (entity == null) { throw new Exception("Not Found"); }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
