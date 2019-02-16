using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankOfBIT_SF.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bank of BIT Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Find our Contact Information here.";

            return View();
        }
    }
}