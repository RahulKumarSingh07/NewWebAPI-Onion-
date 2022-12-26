using ReposatioryLayer.DataBaseEntity;
using ReposatioryLayer;
using ReposatioryLayer.ReposatioryServices;
using ServicesLayer.Interfaces;
using ServicesLayer;

namespace WebApiArchitechture.AllDependencyServices
{
    public class DependencyInjectionServices
    {
        public static void AllDependencyServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IDbContext>(provider => provider.GetService<ApplicationDbContext>());
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
;            builder.Services.AddScoped(typeof(IAsynReposatiory<>), typeof(Reposatiory<>));
            builder.Services.AddScoped(typeof(IReposatiory<>), typeof(Reposatiory<>));
            builder.Services.AddScoped<IStudent, StudentService>();

        }
    }
}
