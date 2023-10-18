using AutoMapper;
using Lupy.Domain.Entities;
using Lupy.Domain.Records.DTOs;

namespace Lupy.Infra.AutoMapper
{
    public class AutoMapperMap : Profile
    {
        public AutoMapperMap() 
        {
            base.CreateMap<ClinicDTO, Clinic>();
            base.CreateMap<Clinic, ClinicDTO>();

            base.CreateMap<PetDTO, Pet>();
            base.CreateMap<Pet, PetDTO>();

            base.CreateMap<RoleDTO, Role>();
            base.CreateMap<Role, RoleDTO>();

            base.CreateMap<UserDTO, User>();
            base.CreateMap<User, UserDTO>();

            base.CreateMap<VaccinePetDTO, VaccinePet>();
            base.CreateMap<VaccinePet, VaccinePetDTO>();

            base.CreateMap<VaccineDTO, Vaccine>();
            base.CreateMap<Vaccine, VaccineDTO>();
        }
    }
}
