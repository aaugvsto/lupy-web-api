using AutoMapper;
using Lupy.Domain.Entities.Base;
using Lupy.Domain.Interfaces.IServices.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LupyAPI.Controllers.Base
{
    public abstract class Controller<TControllerService, TEntity, TEntityDTO> : ControllerBase where TControllerService : IService<TEntity> where TEntity : Entity
    {
        protected readonly TControllerService controllerService;
        protected readonly IMapper mapper;

        public Controller(TControllerService controllerService, IMapper mapper)
        {
            this.controllerService = controllerService;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await this.controllerService.GetAsync());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        [Route("{entityId}")]
        public async Task<IActionResult> Find([FromRoute] int entityId)
        {
            try
            {
                var user = await this.controllerService.FindAsync(entityId);
                return user == null ? NotFound() : Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] TEntityDTO entityDto)
        {
            try
            {
                TEntity newEntity = this.mapper.Map<TEntityDTO, TEntity>(entityDto);

                newEntity.CreationDate = DateTime.Now;
                newEntity.CreationUser = this.User.Identity!.Name!;

                newEntity = await this.controllerService.CreateAsync(newEntity);
                return Created(this.Request.Host + this.Request.Path, this.mapper.Map<TEntity, TEntityDTO>(newEntity));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update([FromBody] TEntityDTO entityDto)
        {
            try
            {
                TEntity updatedEntity = this.mapper.Map<TEntityDTO, TEntity>(entityDto);

                updatedEntity.ModificationDate = DateTime.Now;
                updatedEntity.ModificationUser = this.User.Identity!.Name!;

                await this.controllerService.UpdateAsync(updatedEntity);
                return Created(this.Request.Host + this.Request.Path, entityDto);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        [Route("{entityId}")]
        public async Task<IActionResult> Remove([FromRoute] int entityId)
        {
            try
            {
                return await this.controllerService.DeleteAsync(entityId) ? NoContent() : NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
