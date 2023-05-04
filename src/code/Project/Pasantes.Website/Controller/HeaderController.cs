using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pasantes.Website.Controller
{
    public class HeaderController : System.Web.Mvc.Controller
    {
        public ActionResult SampleHeader()
        {
            return View("~/Views/SampleHeader.cshtml");
        }
    }
}