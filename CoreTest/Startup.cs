using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTest.Data;
using CoreTest.Code.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;

namespace CoreTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            configuration.GetSection("ConnectionStrings").Bind(AppSettings.ConnectionStrings);
        }
        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDistributedMemoryCache();

            services.AddHttpContextAccessor();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(900);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });


            ////注入全局异常处理
            //services.AddMvc(option =>
            //{
            //    option.Filters.Add(typeof(MyCustomerExceptionFilter));
            //});

            services.AddControllersWithViews();//MVC


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // Sets the default scheme to cookies
             .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
             {
                 //options.AccessDeniedPath = "/account/denied";
                 options.LoginPath = "/Home/Login";
                 options.AccessDeniedPath = new PathString("/Home/Login");
                 options.ExpireTimeSpan= TimeSpan.FromSeconds(1000);//登陆过期时间
             });



            //services.AddSingleton(ConnectionMultiplexer.Connect("localhost"));
            //services.AddSingleton(ConnectionMultiplexer.Connect("localhost,allowAdmin=true"));
            //services.AddSingleton(ConnectionMultiplexer.Connect("127.0.0.1:6380,password = 123456,DefaultDatabase = 0,allowAdmin=true"));

            services.AddSingleton(ConnectionMultiplexer.Connect(Configuration.GetConnectionString("RedisConnection")));


            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));
            services.AddScoped<UserSevice>();
            services.AddScoped<SysUserSevice>();

         

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //异常
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseResponseCaching();


            app.UseStaticHttpContext();

            app.UseSession();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();




            //路由
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }


    public static class AppSettings
    {
        public static ConnectionStrings ConnectionStrings { get; set; } = new ConnectionStrings();
    }
    public class ConnectionStrings
    {
        public string SqlServerConnection { get; set; }
        public string RedisConnection { get; set; }
    }


}
