using Data;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace App
{
    public class AbstractController<TEntity, TDto, TCreateDto> : ControllerBase 
        where TEntity : BaseEntity
        where TDto : BaseDto, new()
        where TCreateDto : BaseCreateDto, new()
    {
        private readonly IRepository<TEntity, TDto, TCreateDto> repository;

        public AbstractController(IRepository<TEntity, TDto, TCreateDto> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public TDto Get(Guid id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public async Task<TDto> Create(TCreateDto entity)
        {
            return await repository.CreateAsync(entity);
        }

        [HttpPut]
        public async Task<TEntity> Update(TEntity entity)
        {
            return await repository.UpdateAsync(entity);
        }

        [HttpDelete]
        public Task<bool> Delete(Guid id)
        {
            return repository.DeleteAsync(id);
        }

    }

}
