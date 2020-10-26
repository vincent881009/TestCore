using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreTest.Service;
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
using CoreTest.Service.Model.Layui;
using CoreTest.Service.Model.Query;
using CoreTest.Entity.Models;
using System.Threading;
using Newtonsoft.Json;

namespace CoreTest.Controllers
{
    //[ResponseCache(CacheProfileName = "Default")]
    public class HomeController :BaseController
    {
        private readonly UserSevice _userService;
        private readonly SysUserSevice _sysUserService;
        private readonly IConnectionMultiplexer _redis;
        private readonly IRedisClient _redisClient;
        private readonly IDatabase _db;
        private IServer _server;

        //string connectionStr = Configuration.GetSection("AppSetting")["MapKey"];

        public HomeController(UserSevice userService,SysUserSevice sysUserService, IConnectionMultiplexer redis,IRedisClient redisClient)
        {
            _userService = userService;
            _sysUserService = sysUserService;
            _redis = redis;
            _redisClient = redisClient;
            _db = _redis.GetDatabase();
            _server = redis.GetServer(redis.GetEndPoints()[0]);
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



  
        public IActionResult IndexRedis()
        {
            //_server.FlushAllDatabases();//清空所有数据
            SysUser yuyang=_sysUserService.GetSysUser("yyu");
            string res = "";



            //string类型插入/读取
            _db.StringSet("fullname", "yuyang");
          


            //事务
            var trans = _db.CreateTransaction();
            trans.AddCondition(Condition.StringEqual("fullname", "yuyang"));//相当于Redis命令中的watch name 如果ID和原先不一致 就不更新下一步StringSetAsync
            trans.StringSetAsync("fullname", "EE");
            bool result = trans.Execute();


            res = _db.StringGet("fullname");



            ////Zset排序集合
            //var zset_key = "蜀国Zset";
            //_db.SortedSetAdd(zset_key, "刘备", 1);
            //_db.SortedSetAdd(zset_key, "张飞", 3);
            //_db.SortedSetAdd(zset_key, "关羽", 2);

            //var zset_key2 = "吴国Zset";
            //_db.SortedSetAdd(zset_key2, "孙权", 1);
            //_db.SortedSetAdd(zset_key2, "陆逊", 3);
            //_db.SortedSetAdd(zset_key2, "周瑜", 2);



            ////Hash键值对集合
            //var hashKey = "于洋";
            //_db.HashSet(hashKey, Guid.NewGuid().ToString(), yuyang.LoginName);
            //_db.HashSet(hashKey, Guid.NewGuid().ToString(), yuyang.Name);
            //_db.HashSet(hashKey, Guid.NewGuid().ToString(), yuyang.Pwd);


            ////set排序集合  最大的不同就是List是可以重复的。而Set是不能重复的
            //var set_key2 = "魏国set";
            //_db.SetAdd(set_key2, "曹操");
            //_db.SetAdd(set_key2, "曹操");
            //_db.SetAdd(set_key2, "夏侯惇");
            //_db.SetAdd(set_key2, "夏侯惇");
            //_db.SetAdd(set_key2, "司马懿");
            //_db.SetAdd(set_key2, "司马懿");



            ////List键值对集合 赋值/ 取值
            //var LeftListKey = "LeftPushList";
            //var RightListKey = "RightPushList";
            //_db.ListLeftPush(LeftListKey, "EE");
            //_db.ListLeftPush(LeftListKey, "EE");
            //_db.ListLeftPush(LeftListKey, "YY");
            //_db.ListRightPush(LeftListKey, "YY");


            //_db.ListRightPush(RightListKey, "EE");
            //_db.ListRightPush(RightListKey, "EE");
            //_db.ListRightPush(RightListKey, "YY");
            //_db.ListRightPush(RightListKey, "YY");


            //var resList = _db.ListRange(LeftListKey,0, -1);//获取set集合中所有元素
            //foreach (var item in resList)
            //{
            //    res += item+"||";
            //}
            ////res = _db.ListLeftPop(ListKey);
            //res = _db.ListRightPop(LeftListKey);
            //res2 = _db.ListLeftPop(RightListKey);

            ///分布式锁
            var LockTakeKey = "LockTake";
            //_redisClient.Lock()
            _db.LockTake(LockTakeKey, "lock yy", TimeSpan.FromSeconds(30));


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
            PagedList<SysUser> model = _sysUserService.GetAll2(pageIndex);

           
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
