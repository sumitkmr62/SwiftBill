using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftBiil.Web.UI.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Create()
        {
            return View();
        }
    }
}