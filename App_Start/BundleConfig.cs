using System.Web;
using System.Web.Optimization;

namespace OCRReaderMVCWeb
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Typed.js
            bundles.Add(new ScriptBundle("~/bundles/typed").Include("~/Scripts/typed.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));


            //OCR    
            bundles.Add(new StyleBundle("~/Content/Main/css").Include(
                "~/Content/Main/base.css",
                "~/Content/Main/elements.css",
                "~/Content/Main/grid.css",
                "~/Content/Main/layout.css",
                "~/Content/Main/style.css"
                ));

            //bundles.Add(new StyleBundle("~/Content/OCR/css").Include(
            //    "~/Content/themes/basic/bootstrap.css",
            //    "~/Content/MagnificPopup/magnific-popup.css",
            //    "~/Content/fontawesome/css/font-awesome.css",
            //    "~/Content/Main/base.css",
            //    "~/Content/Main/elements.css",
            //    "~/Content/Main/grid.css",
            //    "~/Content/Main/layout.css",
            //    "~/Content/Main/style.css"
            //    ));
                //"~/Content/Main/base.css",
                //"~/Content/Main/elements.css",
                //"~/Content/Main/grid.css",
                //"~/Content/Main/layout.css",
                //"~/Content/Main/style.css",
                //"~/Content/fontawesome/css/font-awesome.css"));


            //bundles.Add(new ScriptBundle("~/bundles/OCR/js").Include(
            //    "~/Scripts/Basic/bootstrap.js",
            //    "~/Scripts/MagnificPopup/jquery.magnific-popup.min.js",
            //    "~/Scripts/PDF.JS/pdf.js",
            //    "~/Scripts/PDF.JS/pdf.worker.js",
            //    "~/Scripts/OCR/jquery-ocr-starter.js",
            //    "~/Scripts/Layout/easytabs/jquery.easytabs.min.js",
            //    "~/Scripts/Layout/plugins.js",
            //    "~/Scripts/Layout/script.js"
            //    ));            

            BundleTable.EnableOptimizations = true;
        }
    }
}