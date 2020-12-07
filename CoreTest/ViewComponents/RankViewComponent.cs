using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreTest.ViewComponents
{
    public class RankViewComponent : ViewComponent
    {
        private readonly IDatabase _db;
        private readonly ConnectionMultiplexer _redis;
        private IServer _server;

        public RankViewComponent(ConnectionMultiplexer redis)
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
            var code = RouteData.Values["code"] as string;
            if (!string.IsNullOrWhiteSpace(controller) && !string.IsNullOrWhiteSpace(action)&& !string.IsNullOrWhiteSpace(code))
            {
                var pageid = $"{controller}-{action}--{code}";

                var count = await _db.StringGetAsync(pageid);
                _db.SortedSetAdd("product", new SortedSetEntry[]
                {
                    new SortedSetEntry(pageid,Convert.ToDouble(count))
                });
                //var count = await _db.StringGetAsync(pageid);
                var rank = await _db.SortedSetRangeByRankWithScoresAsync("product", 0, -1, Order.Descending);
                return View("Default", rank);
            }
            var rank2 = await _db.SortedSetRangeByRankWithScoresAsync("product", 0, -1, Order.Descending);
            return View("Default", rank2);
            //throw new Exception("cannot get pageId");
        }

       
    }
}
