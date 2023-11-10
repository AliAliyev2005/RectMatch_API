using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RectMatch_API.Application.Interfaces.Repository;
using RectMatch_API.Persistence.Context;
using RectMatch_API.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Persistence.Extensions
{
    public static class Registration
    {
        public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(conf =>
            {
                var connStr = configuration["ConnectionString"].ToString();
                conf.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

            services.AddScoped<IRectangleRepository, RectangleRepository>();

            // Adding random data into the database
            SeedData.SeedAsync(configuration);

            return services;
        }
    }
}
