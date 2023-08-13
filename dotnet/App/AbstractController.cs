using Business;
using Business.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace App;

public class AbstractController<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> : ControllerBase
    where TEntity : BaseEntity
    where TDto : BaseDto, new()
    where TCreateDto : BaseCreateDto, new()
    where TUpdateDto : BaseUpdateDto, new()
    where TQueryDto : BaseQueryDto, new()
{
    private readonly IBaseEntityService<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> service;

    public AbstractController(IBaseEntityService<TEntity, TDto, TCreateDto, TUpdateDto, TQueryDto> service)
    {
        this.service = service;
    }

    [HttpGet(nameof(Get))]
    [UserAuthorize]
    public TDto Get(Guid id)
    {
        return service.Get(id);
    }

    [HttpPost(nameof(Create))]
    [AdminAuthorize]
    public async Task<TDto> Create(TCreateDto entity)
    {
        return await service.CreateAsync(entity);
    }

    [HttpPut(nameof(Update))]
    [AdminAuthorize]
    public async Task<TDto> Update(TUpdateDto entity)
    {
        return await service.UpdateAsync(entity);
    }

    [HttpDelete(nameof(Delete))]
    [AdminAuthorize]
    public Task<bool> Delete(Guid id)
    {
        return service.DeleteAsync(id);
    }

    [HttpPost(nameof(Query))]
    [UserAuthorize]
    public List<TDto> Query(TQueryDto query)
    {
        return service.QueryAsync(query);
    }
}