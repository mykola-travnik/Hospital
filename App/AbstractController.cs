using Data;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace App
{
    public class AbstractController<TEntity> : ControllerBase where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> repository;

        public AbstractController(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public TEntity Get(Guid id)
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
