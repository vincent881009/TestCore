using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreTest.ViewComponents
{
    public class CounterViewComponent:ViewComponent
    {
        private readonly IDatabase _db;
        private readonly ConnectionMultiplexer _redis;
        private IServer _server;

        public CounterViewComponent(ConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
            _redis = redis;
            _server =redis.GetServer(redis.GetEndPoints()[0]);
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            //_server.FlushAllDatabases();//清空所有数据 ，然后连接字符串要加：allowAdmin=true


            var controller = RouteData.Values["controller"] as string;
            var action = RouteData.Values["action"] as  string;
            if (!string.IsNullOrWhiteSpace(controller) && !string.IsNullOrWhiteSpace(action))
            {
                var pageid = $"{controller}-{action}";
                await _db.StringIncrementAsync(pageid);

                var count = await _db.StringGetAsync(pageid);
                return View("Default", pageid+"|"+count);
            }
            return View("Default", 0);
            //throw new Exception("cannot get pageId");
        }

    }
}
