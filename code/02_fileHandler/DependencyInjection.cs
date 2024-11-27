using Lenex.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Lenex.Handler
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLenex(this IServiceCollection services)
        {
            services.AddTransient<ILenexFileHandler, FileHandler>();

            return services;
        }
    }
}
