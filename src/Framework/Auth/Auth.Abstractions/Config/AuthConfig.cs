using NetModular.Lib.Config.Abstractions;

namespace NetModular.Lib.Auth.Abstractions.Config
{
    /// <summary>
    /// 身份认证和授权配置
    /// </summary>
    public class AuthConfig : IConfig
    {
        /// <summary>
        /// 启用验证码功能
        /// </summary>
        public bool VerifyCode { get; set; }

        /// <summary>
        /// 开启权限验证
        /// </summary>
        public bool Validate { get; set; }

        /// <summary>
        /// 开启按钮权限
        /// </summary>
        public bool Button { get; set; }

        /// <summary>
        /// 单账户登录
        /// </summary>
        public bool SingleAccount { get; set; }

        /// <summary>
        /// 启用审计日志
        /// </summary>
        public bool Auditing { get; set; }

        /// <summary>
        /// Jwt配置
        /// </summary>
        public JwtConfig Jwt { get; set; } = new JwtConfig();

        /// <summary>
        /// 登录
        /// </summary>
        public LoginModeConfig LoginMode { get; set; } = new LoginModeConfig();
    }

}
