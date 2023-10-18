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
    public class VaccineController : Controller<IVaccineService, Vaccine, VaccineDTO>
    {
        public VaccineController(IVaccineService controllerService, IMapper mapper) : base(controllerService, mapper)
        {
        }
    }
}