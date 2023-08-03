using Data;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace App
{
    public class AbstractController<TEntity, TDto> : ControllerBase where TEntity : BaseEntity where TDto : BaseDto, new()
     {
        private readonly IRepository<TEntity, TDto> repository;

        public AbstractController(IRepository<TEntity, TDto> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public TDto Get(Guid id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public async Task<TEntity> Create(TEntity entity)
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
