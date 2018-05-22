using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftBiil.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        //Home 
        public ActionResult Index()
        {
            return View();
        }

        //About
        public ActionResult About()
        {
            return View();
        }

        //Feedback contact for suggestions, questions and complaints 
        public ActionResult Contact()
        {
            return View();
        }
    }
}