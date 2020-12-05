using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Controllers
{
    public class ErrorPageController : Controller
    {


        [Route("Error/404")]
        public IActionResult Error404()
        {
            return View();
        }
        [Route("Error/500")]
        public IActionResult Error500()
        {
            return View();
        }

        [Route("Error/{code:int}")]
        public IActionResult Error(int code)
        {
            ViewBag.code = code;
            return View();
        }



    }
}
