
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCRReaderMVCWeb.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
          //  string ipAddress = Request.ServerVariables["REMOTE_ADDR"] + " , ";
        //    Logger.Error(ipAddress + "Some error occurred. Error page requested");
            return View();
        }
    }
}