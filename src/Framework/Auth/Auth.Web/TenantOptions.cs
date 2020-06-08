using Microsoft.Extensions.DependencyInjection;
using NetModular.Lib.Auth.Abstractions;

namespace NetModular.Lib.Auth.Web
{
    /// <summary>
    /// 租户配置
    /// </summary>
    public class TenantOptions
    {
        private readonly IServiceCollection _service;

        public TenantOptions(IServiceCollection service)
        {
            _service = service;
        }

        /// <summary>
        /// 是否开启租户功能
        /// </summary>
        public bool Enabled { get; set; }
        
        /// <summary>
        /// 使用解析器
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void UseResolver<T>() where T : ITenantResolver
        {
            _service.Add(new ServiceDescriptor(typeof(ITenantResolver), typeof(T), ServiceLifetime.Singleton));
        }
    }
}
