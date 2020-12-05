using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Thinktecture.IdentityModel.Authorization.WebApi;

namespace CoreTestWebAPI.Controllers
{
    //[Route("api/Home")]
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 获取home对象
        /// </summary>
        /// <remarks>
        /// 例子:
        /// Get/1/2/3/yuyang
        /// </remarks>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <param name="name">姓名</param>
        /// <returns>测试结果字符串！！</returns> 
        [HttpGet]
        //[ApiAuthorize]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [SwaggerResponse((int)System.Net.HttpStatusCode.InternalServerError)]
        [Route("{year}/{month}/{day?}/{name?}")]
        //[SwaggerOperationFilter(typeof(Filters))]
        public JsonResult Get([FromRoute]int year, [FromRoute] int month, [FromRoute] int? day=null,[FromRoute]string name = null)
        {
            //var res= $"你请求的 year ： {year},month：{month},day：{day},name：{name}";
            //return res;
           
            var yy = new
            {
                date = DateTime.Now,
                name = "yyu"
            };
           
            return new JsonResult(yy) ;
        }

        




        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}
