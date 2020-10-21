using CoreTest.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreTest.Data
{
    public class UserSevice
    {
        private readonly MyDbContext _context;

        public UserSevice(MyDbContext context) {
            _context = context;
        }


        public IList<User> GetUserList()
        {
            return _context.User.AsNoTracking().ToList();
        }


        //public IList<User> GetUserList()
        //{
        //    return _context.User.AsNoTracking().ToList();
        //}

        public User GetUser(string account,string password)
        {
            return _context.User.FirstOrDefault(r => r.Loginname == account);
        }
        public User GetUserById(string Id)
        {
            return _context.User.FirstOrDefault(r => r.Id ==  new Guid(Id));
        }


    }
}
