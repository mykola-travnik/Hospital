using Data;
using Data.QueryDto;
using Data.Repositories;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace App
{
    public class AbstractController<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> : ControllerBase 
        where TEntity : BaseEntity
        where TDto : BaseDto, new()
        where TCreateDto : BaseCreateDto, new()
        where TUpdateDto : BaseUpdateDto, new()
        where TQueryDto : BaseQueryDto, new()
    {
        private readonly IRepository<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> repository;

        public AbstractController(IRepository<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(Get))]
        public TDto Get(Guid id)
        {
            return repository.Get(id);
        }

        [HttpPost(nameof(Create))]
        public async Task<TDto> Create(TCreateDto entity)
        {
            return await repository.CreateAsync(entity);
        }

        [HttpPut(nameof(Update))]
        public async Task<TDto> Update(TUpdateDto entity)
        {
            return await repository.UpdateAsync(entity);
        }

        [HttpDelete(nameof(Delete))]
        public Task<bool> Delete(Guid id)
        {
            return repository.DeleteAsync(id);
        }

        [HttpPost(nameof(Query))]
        public List<TDto> Query(TQueryDto query)
        {

            return repository.QueryAsync(query);
        }

    }

}
