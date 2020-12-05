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

namespace CoreTest.Service
{
    public class SysUserSevice
    {
        private readonly GamblingContext _context;

        public SysUserSevice(GamblingContext context) {
            _context = context;
        }

       
        public IList<SysUser> GetSysUserList()
        {
            return _context.SysUser.AsNoTracking().ToList();
        }

        public PagedListLayUI<SysUser> GetAll(SysUserQuery sysUserQuery)
        {
            IQueryable<SysUser> query = _context.SysUser.AsNoTracking();
            return query.ToPagedListLayUI(sysUserQuery.page - 1, sysUserQuery.limit);
        }

        public PagedList<SysUser> GetAll2(int? pageIndex)
        {
            IQueryable<SysUser> query = _context.SysUser.AsNoTracking();
            int pageSize = 5;
            var page = pageIndex ?? 1;
            return (PagedList<SysUser>)query.ToPagedList(page,pageSize);
        }



        public SysUser GetSysUser(string account)
        {
            return _context.SysUser.FirstOrDefault(r => r.LoginName == account);
        }
        public SysUser GetSysUser(string account,string password)
        {
            return _context.SysUser.FirstOrDefault(r => r.LoginName == account);
        }
        public SysUser GetSysUserById(string Id)
        {
            return _context.SysUser.FirstOrDefault(r => r.Id ==  new Guid(Id));
        }


        public Task<(string ReturnMsg, SysUser ReturnObject)> LoginUserAsync(string loginname, string password)
        {
            (string outmess, SysUser user) result;
            string outmess = string.Empty;
            string md5pwd = EncryptHelper.MD5(password);
            var user = _context.SysUser.FirstOrDefault(item => item.LoginName == loginname && item.Pwd == md5pwd);
            if (user != null)
            {
                //登录判断是否被禁用
                if (user.Stauts == "1")
                {
                    outmess = "该账号已被禁用";
                }
                //if (user.ValidTime.HasValue && user.ValidTime.Value < DateTime.Now)
                //{
                //    outmess = "该账号已过有效期";
                //}
            }
            else
            {
                outmess = "账号或者密码无效";
            }
            if (!string.IsNullOrEmpty(outmess))
            {
                result = (outmess, null);
            }
            else
            {
                var tuser = _context.SysUser.First(r => r.LoginName == loginname);
                //tuser.LoginCount = tuser.LoginCount.GetValueOrDefault(0) + 1;
                _context.SaveChanges();
                result = (outmess, user);
            }
            return Task.FromResult(result);
        }




    }
}
