using System;
using Microsoft.Extensions.DependencyInjection;

namespace NetModular.Lib.Auth.Web
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加多租户功能
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configureOptions">租户功能配置</param>
        /// <returns></returns>
        public static IServiceCollection AddTenant(this IServiceCollection services, Action<TenantOptions> configureOptions)
        {
            if (configureOptions == null)
                throw new ArgumentNullException(nameof(configureOptions), "请配置租户功能");

            var options = new TenantOptions(services);

            configureOptions(options);

            services.AddSingleton(options);

            return services;
        }
    }
}
