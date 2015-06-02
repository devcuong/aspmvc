using HelloMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HelloModels model = new HelloModels();
            ViewData["Id"] = model.Id;
            ViewData["Name"] = model.Name;
            ViewData["Address"] = model.Address;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
