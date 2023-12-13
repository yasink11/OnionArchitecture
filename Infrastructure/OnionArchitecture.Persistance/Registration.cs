using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces.Repositories;
using OnionArchitecture.Application.Interfaces.UnitOfWorks;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Persistance.Context;
using OnionArchitecture.Persistance.Repositories;
using OnionArchitecture.Persistance.UnitOfWorks;

namespace OnionArchitecture.Persistance
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 2;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;

            })
                .AddRoles<Role>()
                .AddEntityFrameworkStores<AppDbContext>();
        }
    }
}