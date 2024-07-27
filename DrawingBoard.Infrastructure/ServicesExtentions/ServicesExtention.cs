using DrawingBoard.Core.Entities;
using DrawingBoard.Core.Interfaces;
using DrawingBoard.Infrastructure.Data;
using DrawingBoard.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DrawingBoard.Infrastructure
{
    public static class ServicesContainer
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("UserHubConnection"),
                b => b.MigrationsAssembly(typeof(ServicesContainer).Assembly.FullName)),
                ServiceLifetime.Scoped);

        }
    }
}
