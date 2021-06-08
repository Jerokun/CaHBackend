using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CahBackend.Mappings
{
    // Mapping demo
    public static class MappingExtensions
    {
        public static void AddMappingProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(GameStateMappings));
        }
    }
}
