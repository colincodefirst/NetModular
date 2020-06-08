using System;

namespace NetModular.Lib.Auth.Abstractions
{
    /// <summary>
    /// 租户解析器
    /// </summary>
    public interface ITenantResolver
    {
        /// <summary>
        /// 解析租户编号(TenantId)
        /// </summary>
        /// <returns></returns>
        Guid Resolve();
    }
}
