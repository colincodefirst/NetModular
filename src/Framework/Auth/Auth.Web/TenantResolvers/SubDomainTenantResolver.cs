using System;
using NetModular.Lib.Auth.Abstractions;

namespace NetModular.Lib.Auth.Web.TenantResolvers
{
    /// <summary>
    /// 子域名租户解析器
    /// </summary>
    public class SubDomainTenantResolver : ITenantResolver
    {
        public Guid Resolve()
        {
            throw new NotImplementedException();
        }
    }
}
