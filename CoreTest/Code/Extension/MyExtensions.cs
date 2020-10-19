using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Code.Extensions
{
    public static class MyExtensions
    {
        //public static bool HasAuthority(this SysUser source, string value)
        //{
        //    if (!string.IsNullOrEmpty(value))
        //    {
        //        if (!string.IsNullOrEmpty(source.auth))
        //        {
        //            SysUserSevice sysUserService = System.Web.HttpContext.Current.RequestServices.GetRequiredService<SysUserSevice>();
        //            var menuList = sysUserService.GetMenuAuthListPage(source.auth);
        //            var menuList= sysUserService
        //            return menuList.Any(r => r.Contains(value.TrimEnd('/')));
        //        }
        //        else
        //            return false;
        //    }
        //    else
        //        return false;
        //}
    }
}
