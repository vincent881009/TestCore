using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CoreTestWebAPI.Controllers
{
    //[Route("api/Home")]
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 这是一个带参数的get请求
        /// </summary>
        /// <remarks>
        /// 例子:
        /// Get/1/2/3
        /// </remarks>
        /// <param name="id">主键</param>
        /// <returns>测试字符串</returns> 
        [HttpGet]
        [Route("{year}/{month}/{day?}")]
        //[SwaggerOperationFilter(typeof(Filters))]
        public string Get([FromRoute]int year, [FromRoute] int month, [FromRoute] int? day=null)
        {
            return "Tom";
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
