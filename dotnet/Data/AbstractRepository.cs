using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public abstract class AbstractRepository<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> : IRepository<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto>
        where TEntity : BaseEntity
        where TDto : BaseDto, new()
        where TCreateDto : BaseCreateDto, new()
        where TUpdateDto : BaseUpdateDto, new()
        where TQueryDto : BaseQueryDto, new()

    {
        private readonly DbContext _context;
        private readonly IMapper mapper;

        public virtual List<TDto> QueryAsync(TQueryDto query) { return new List<TDto>(); }

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

            var dto = mapper.Map<TEntity, TDto>(newEntity);

            return dto;
        }

        public async Task<TDto> UpdateAsync(TUpdateDto dto)
        {
            if (dto == null) { throw new Exception("Not Found"); }

            var updateEntity = GetQueryable().AsNoTracking().FirstOrDefault(updateEntity => updateEntity.Id == dto.Id);

            if (updateEntity == null) { throw new Exception("Not Found"); }

            updateEntity = mapper.Map(dto, updateEntity);

            updateEntity.ModifiedTimestamp = DateTime.Now.ToUniversalTime();

            _context.Set<TEntity>().Update(updateEntity);
            await _context.SaveChangesAsync();

            return mapper.Map<TEntity, TDto>(updateEntity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = GetQueryable().FirstOrDefault(entity => entity.Id == id);

            if (entity == default) { throw new Exception("Not Found"); }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Для сидинга данных
        /// </summary>
        /// <param name="entity">Сущность для записи</param>
        public async Task SeedData(List<TEntity> entities)
        {
            entities.ForEach(async entity =>
            {
                if (entity == null) { throw new Exception("Not Found"); }

                var updateEntity = GetQueryable().AsNoTracking().FirstOrDefault(updateEntity => updateEntity.Id == entity.Id);

                if (updateEntity == default)
                    await _context.Set<TEntity>().AddAsync(entity);
                else
                    _context.Set<TEntity>().Update(entity);
            });

            await _context.SaveChangesAsync();
        }

        protected List<TDto> Find(Func<TEntity, bool> predicate)
        {
            var result = _context.Set<TEntity>().Where(predicate).ToList();

            if (!result.Any())
                return new List<TDto>();

            return result.Select(item => mapper.Map<TEntity, TDto>(item)).ToList();
        }
    }
}
