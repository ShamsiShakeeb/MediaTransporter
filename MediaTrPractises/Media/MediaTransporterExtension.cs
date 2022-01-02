using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MediaTrPractises.Media
{
    public static class MediaTransporterExtension
    {
        public static void AddHelperServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IMediaTransporter<,>), typeof(MediaTransporter<,>));
            var type = typeof(IEventHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.Name != typeof(IEventHandler).Name)
                .ToList();

            foreach (var item in types)
            {
                services.AddScoped(item);
            }

        }
    }
}
