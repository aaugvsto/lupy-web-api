using AutoMapper;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IServices;
using Lupy.Domain.Records;
using Lupy.Domain.Records.DTOs;
using Lupy.Domain.Services;
using LupyAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LupyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller<IUserService, User, UserDTO>
    {
        public UserController(IUserService controllerService, IMapper mapper) : base(controllerService, mapper)
        {
        }

        [HttpGet]
        [Route("Authenticate")]
        public async Task<IActionResult> Authenticate([FromQuery] UserLoginDTO loginDto)
        {
            if (!this.ModelState.IsValid)
                return BadRequest(this.ModelState.ValidationState);

            try
            {
                var dbUser = await base.controllerService.Authenticate(loginDto);
                return dbUser != null ? Ok(new { Token = TokenService.Generate(new AuthUser(dbUser.Email, dbUser.IdRole)), dbUser.Name, dbUser.IdRole, Clinic = dbUser.Clinic.Name }) : NotFound();
            }
            catch (Exception ex) 
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}