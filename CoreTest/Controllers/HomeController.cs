using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreTest.Data;
using CoreTest.Code;
using CoreTest.Code.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.Extensions.Configuration;
using X.PagedList;
using StackExchange.Redis;
using CoreTest.Utility;
using CoreTest.Data.Model.Layui;
using CoreTest.Data.Model.Query;
using CoreTest.Entity.Models;

namespace CoreTest.Controllers
{
    //[ResponseCache(CacheProfileName = "Default")]
    public class HomeController :BaseController
    {
        private readonly UserSevice _userService;
        private readonly SysUserSevice _sysUserService;
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;

        //string connectionStr = Configuration.GetSection("AppSetting")["MapKey"];

        public HomeController(UserSevice userService,SysUserSevice sysUserService,ConnectionMultiplexer redis)
        {
            _userService = userService;
            _sysUserService = sysUserService;
            _redis = redis;
            _db = _redis.GetDatabase();
        }

        private static IConfiguration configuration;
        public static IConfiguration Configuration
        {
            get
            {
                if (configuration != null)
                    return configuration;
                else
                {
                    var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    configuration = builder.Build();
                    return configuration;
                }
            }
            set
            {
                configuration = value;
            }
        }



        //传统方式
        //_db.StringSet("fullname", "yuyang2");
        //var name = _db.StringGet("fullname");
        public IActionResult IndexRedis()
        {
            RedisHelper.Set("fullname", "yuyang", 1);
            var res = RedisHelper.Get("fullname");
            ViewBag.name = res;
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexLayUI()
        {
            return View();
        }
        public IActionResult IndexTable( int? pageIndex)
        {
            var model= _sysUserService.GetAll2(pageIndex);
            return View(model);
        }
        
        public LayuiResult GetSysUser(SysUserQuery sysUserQuery)
        {
            var result = ProcessLayuiData(() =>
            {
                return _sysUserService.GetAll(sysUserQuery);
            });
            return result;
        }

        public X.PagedList.IPagedList<SysUser> GetSysUser2(int? pageIndex)
        {
            return _sysUserService.GetAll2(pageIndex);
        }



        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//防止CSRF攻击
        [AllowAnonymous]
        public async Task<IActionResult> Login(string account, string password)
        {
            //var LoginName = this.Request.Form["LoginName"];
            //var Password = this.Request.Form["Password"];

            var result = await _sysUserService.LoginUserAsync(account, password);
            if (string.IsNullOrEmpty(result.ReturnMsg))
            {
                var user = result.ReturnObject;
                ClaimsIdentity ident = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.LoginName) }, "ApplicationCookie", ClaimTypes.Name, ClaimTypes.Role);
                ident.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));


                var claimsPrincipal = new ClaimsPrincipal(ident);
                //await HttpContext.SignOutAsync();
                await HttpContext.SignInAsync(claimsPrincipal, new AuthenticationProperties { IsPersistent = false });
                HttpContext.Session.Set("yuyang", user);

                //SyslogService syslogService = HttpContext.RequestServices.GetRequiredService<SyslogService>();
                //_ = syslogService.AddLog("系统登录", $"用户 {LoginName} 成功登录系统，IP：{HttpContext.Connection.RemoteIpAddress}");

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.mess = result.ReturnMsg;
            }
            return View();
        }



        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    
        






        protected void SetSession(string key, string value)
        {
            HttpContext.Session.SetString(key, value);
        }

        /// <summary>
        /// 获取Session
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回对应的值</returns>
        protected string GetSession(string key)
        {
            var value = HttpContext.Session.GetString(key);
            if (string.IsNullOrEmpty(value))
                value = string.Empty;
            return value;
        }
    }

    
}
