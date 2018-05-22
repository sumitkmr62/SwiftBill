using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftBiil.Web.UI.Controllers
{
    public class QuotationController : Controller
    {
        // GET: Quotation
        public ActionResult Create()
        {
            return View();
        }
    }
}