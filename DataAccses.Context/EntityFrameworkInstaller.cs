using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Context
{
    public static class EntityFrameworkInstaller
    {
        public static IServiceCollection ConfigureInMemContext(this IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>(
                opt => opt
                    .UseInMemoryDatabase("InMem"));
            return services;
        }
    }
}
