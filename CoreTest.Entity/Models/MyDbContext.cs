using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Entity.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext()
        {
        }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Gambling;Integrated Security=True");
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }

    }
}
