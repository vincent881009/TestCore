using CoreTest.Service.Interface;
using CoreTest.Service.Model.Layui;
using CoreTest.Service.Model.Query;
using CoreTest.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace CoreTest.Controllers
{
    public class OrderController : BaseController
    {

        private readonly IOrderSevice _orderSevice;
        private readonly IConnectionMultiplexer _redis;
        private readonly IRedisClient _redisClient;
        private readonly IDatabase _db;
        private readonly IServer _server;

        public OrderController(IOrderSevice orderSevice, IConnectionMultiplexer redis, IRedisClient redisClient)
        {
            _orderSevice = orderSevice;
            _redis = redis;
            _redisClient = redisClient;
            _db = _redis.GetDatabase();
            _server = redis.GetServer(redis.GetEndPoints()[0]);
        }




        // GET: OrderController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderController/Details/5
        public ActionResult Details([FromRoute] string code)
        {
            var data = _orderSevice.GetOne(code);
            return View(data);
        }
        public LayuiResult GetOrder(OrderQuery orderQuery)
        {
            var result = ProcessLayuiData(() =>
            {
                return _orderSevice.GetAll(orderQuery);
            });
            return result;
        }




        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
