﻿using System.Threading.Tasks;
using NetModular.Module.Admin.Application.AuthService.ResultModels;
using NetModular.Module.Admin.Application.AuthService.ViewModels;

namespace NetModular.Module.Admin.Application.AuthService.LoginHandler
{
    /// <summary>
    /// 用户名登录处理器
    /// </summary>
    public interface IUserNameLoginHandler
    {
        /// <summary>
        /// 登录处理
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<ResultModel<LoginResultModel>> Handle(UserNameLoginModel model);
    }
}
