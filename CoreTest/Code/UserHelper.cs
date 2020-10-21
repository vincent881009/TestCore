using CoreTest.Code.Extensions;
using CoreTest.Data;
using CoreTest.Entity;
using CoreTest.Entity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace CoreTest.Code
{
    public class UserHelper
    {
        public static readonly string LoginUserSession = "GetLoginUser_yuyang";


        public static SysUser GetLoginUser()
        {
            var context = HttpContext.Current;
            if (context.Session.Get<SysUser>(LoginUserSession) == null)
            {
                var state = context.AuthenticateAsync().Result;
                if (state.Succeeded)
                {
                    ClaimsIdentity ident = (ClaimsIdentity)state.Principal.Identity;
                    SysUserSevice sysUserSevice = HttpContext.Current.RequestServices.GetRequiredService<SysUserSevice>();
                    SysUser user = sysUserSevice.GetSysUserById(ident.Claims.FirstOrDefault(r => r.Type == ClaimTypes.NameIdentifier).Value);
                    if (user == null)
                    {
                        throw new Exception("无效的登录用户");
                    }
                    else
                    {
                        //var allUser = userSevice.GetUserList(user.ProjectId);
                        //if (allUser.Count > 0)
                        //{
                        //    user.loginname = allUser.Select(r => r.LoginName).Distinct().ToArray();
                        //    user.id = allUser.Select(r => r.Id).Distinct().ToArray();
                        //}
                        //else
                        //{
                        //    user.loginname = new string[] { };
                        //    user.id = new string[] { };
                        //}

                        context.Session.Set(LoginUserSession, user);
                        return user;
                    }
                }
                else {
                    throw new Exception("请先登录");
                }
            }
            else
                return context.Session.Get<SysUser>(LoginUserSession);
        }




    }
}
