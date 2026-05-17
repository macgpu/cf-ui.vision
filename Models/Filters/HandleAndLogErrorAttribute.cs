
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCRReaderMVCWeb.Models.Filters
{
    public class HandleAndLogErrorAttribute : HandleErrorAttribute
    {
        private bool IsAjax(ExceptionContext filterContext)
        {
            return filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }

        public override void OnException(ExceptionContext filterContext)
        {
            //If either the exception is handled OR customer error is not enabled
            if (filterContext.ExceptionHandled || !filterContext.HttpContext.IsCustomErrorEnabled) return;

            //Log the error
            //Logger.Error("Error occurred: " + filterContext.Exception.Message);
            //Logger.Error(filterContext.Exception);

            //If request is AJAX - then return JSON
            if (IsAjax(filterContext))
            {
                filterContext.Result = new JsonResult() { Data = filterContext.Exception.Message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                filterContext.ExceptionHandled = true;
                filterContext.HttpContext.Response.Clear();
            }
            //If request is not AJAX - then return view
            else
            {
                base.OnException(filterContext);
            }            
        }
    }
}