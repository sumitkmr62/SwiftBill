using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftBiil.Web.UI.Controllers
{
    public class SalesReportController : Controller
    {
        // GET: SalesReport
        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult QuotationProformaChallan()
        {
            return View();
        }

        public ActionResult Clients()
        {
            return View();
        }

        public ActionResult ProductServices()
        {
            return View();
        }
    }
}