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
    public class ClinicController : Controller<IClinicService, Clinic, ClinicDTO>
    {
        public ClinicController(IClinicService controllerService, IMapper mapper) : base(controllerService, mapper)
        {
        }
    }
}