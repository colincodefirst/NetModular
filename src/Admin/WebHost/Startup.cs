using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetModular.Lib.Auth.Web;
using NetModular.Lib.Auth.Web.TenantResolvers;
using NetModular.Lib.Host.Web;

namespace NetModular.Module.Admin.WebHost
{
    public class Startup : StartupAbstract
    {
        public Startup(IHostEnvironment env, IConfiguration cfg) : base(env, cfg)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            //添加租户功能
            services.AddTenant(options =>
            {
                options.UseResolver<SubDomainTenantResolver>();
            });
        }
    }
}
