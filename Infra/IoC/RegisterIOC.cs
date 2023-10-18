using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories.Base;
using Lupy.Domain.Interfaces.IServices;
using Lupy.Domain.Services;
using Lupy.Infra.Authentication;
using Lupy.Infra.AutoMapper;
using Lupy.Infra.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Lupy.Infra.IoC
{
    public static class IOC
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            var services = builder.Services;

            services.AddControllers();

            #region Authentication

            services.AddAuthorization();

            services.AddCors(policyBuilder =>
                            policyBuilder.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyHeader()));

            services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.PrivateKey)),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                    };
                });

            #endregion

            #region DBContext

            services.AddDbContext<DBContext>(db =>
                db.UseSqlServer(Environment.GetEnvironmentVariable("CONNECTION_STRING"))
                );

            #endregion

            #region Add Services/Repos

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRepository<User>, UserRepository>();

            services.AddScoped<IClinicService, ClinicService>();
            services.AddScoped<IRepository<Clinic>, ClinicRepository>();

            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IRepository<Pet>, PetRepository>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRepository<Role>, RoleRepository>();

            services.AddScoped<IVaccineService, VaccineService>();
            services.AddScoped<IRepository<Vaccine>, VaccineRepository>();

            services.AddScoped<IVaccinePetService, VaccinePetService>();
            services.AddScoped<IRepository<VaccinePet>, VaccinePetRepository>();

            #endregion

            #region AutoMapper 

            services.AddAutoMapper(typeof(AutoMapperMap));

            #endregion
        }
    }
}
