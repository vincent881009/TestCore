using CoreTest.Service.Extension;
using CoreTest.Service.Helper;
using CoreTest.Service.Model;
using CoreTest.Service.Model.Query;
using CoreTest.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;
using CoreTest.Service.Interface;

namespace CoreTest.Service
{
    public class OrderSevice: IOrderSevice
    {
        private readonly GamblingContext _context;
        public OrderSevice(GamblingContext context)
        {
            _context = context;
        }

        //public IList<OrderCsp> OrderList => _context.OrderCsp.AsNoTracking().ToList();

      
        public IList<Order> GetOrderList()
        {
          return  _context.Order.AsNoTracking().ToList();
        }

        public PagedListLayUI<Order> GetAll(OrderQuery orderQuery)
        {
            IQueryable<Order> query = _context.Order.AsNoTracking();
            return query.ToPagedListLayUI(orderQuery.page - 1, orderQuery.limit);
        }


    }
}
