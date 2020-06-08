using System;
using NetModular.Lib.Auth.Abstractions;
using NetModular.Lib.Utils.Core.Attributes;

namespace NetModular.Lib.Auth.Web.TenantResolvers
{
    /// <summary>
    /// 默认租户解析器
    /// </summary>
    [Singleton]
    public class DefaultTenantResolver : ITenantResolver
    {
        public Guid Resolve()
        {
            return Guid.Empty;
        }
    }
}
