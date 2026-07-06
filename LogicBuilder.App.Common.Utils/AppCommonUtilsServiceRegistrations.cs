#pragma warning disable IDE0130 //Microsoft recommended namespace for service registrations
using LogicBuilder.App.Common.Utils;
using LogicBuilder.App.Common.Utils.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
#pragma warning restore IDE0130
{
    public static class AppCommonUtilsServiceRegistrations
    {
        public static IServiceCollection AddAppCommonUtilsServices(this IServiceCollection services)
        {
            return services
                .AddTransient<IDictionaryHelper, DictionaryHelper>()
                .AddTransient<IMappingOperations, MappingOperations>();
        }
    }
}
