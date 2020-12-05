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

namespace CoreTest.Service.Interface
{
    public interface IOrderSevice
    {
         IList<Order> GetOrderList();
         PagedListLayUI<Order> GetAll(OrderQuery orderQuery);
    }
}
