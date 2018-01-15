using System;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_5_Basics.Controllers
{
    public class TestController : Controller
    {
        // GET: /Test
        
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Test/Welcome

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

    }
}