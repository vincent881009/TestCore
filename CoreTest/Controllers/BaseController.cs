using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTest.Service.Model;
using CoreTest.Service.Model.Layui;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreTest.Controllers
{

    [Authorize]
    public class BaseController : Controller
    {

        protected string QueryUserId => Code.UserHelper.GetLoginUser().Id.ToString();

        protected virtual LayuiResult ProcessLayuiData<T>(Func<PagedListLayUI<T>> action)
        {
            try
            {
                var list = action();
                return new LayuiResult { count = list.TotalCount, data = list };

            }
            catch (Exception ex)
            {
                if (ex is ViewException)
                {
                }
                else
                {
                    ////记录日志
                    //SyslogService syslogService = HttpContext.RequestServices.GetRequiredService<SyslogService>();
                    //syslogService.AddError(ex, ex.Message);
                }

                return new LayuiResult { count = 0, data = new object[] { } };
            }
        }




    }
}
