using OCRReaderMVCWeb.Models.Filters;
using System.Web;
using System.Web.Mvc;

namespace OCRReaderMVCWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Add customer exception handling filter - to handle exceptions globally
          //xxxxxx  filters.Add(new HandleAndLogErrorAttribute());
        }
    }
}