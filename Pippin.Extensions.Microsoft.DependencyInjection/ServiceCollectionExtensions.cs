using Microsoft.Extensions.DependencyInjection;
using Pippin.Core;
using System;
using System.Linq;
using System.Reflection;

namespace Pippin
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPippin(this IServiceCollection services, Action<PippinOptions> setup)
        {
            var options = new PippinOptions();
            setup?.Invoke(options);
            services.AddTransient<IPinSetter>(serviceProvider => new PinSetter(options.AdapterFactories.Select(af => af())));
            return services;
        }
    }
}
