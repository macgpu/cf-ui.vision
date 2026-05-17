
using Newtonsoft.Json;
using OCRReaderMVCWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OCRReaderMVCWeb.Controllers
{
    //[RoutePrefix("OCR")]
    public class OCRController : Controller
    {
        //


        /// <summary>
        /// Index page
        /// </summary>
        /// <returns>OCR Page</returns>
        /// 


        //*******************************************************************************
        // BEI Änderunge hier immer auch die DLLn im /BIN foler updaten 
        //***********************************************************

        /// this is for the main page
        public ActionResult Index()
        {
       //     ViewBag.Title = "AI Powered Web and Desktop Automation, OCR - 2019 Robotic Process Automation (RPA)";
       //     ViewBag.Description = "Get Kantu - the only modern automation software for Windows, Mac and Linux. Kantu is Browser Automation, Desktop Automation and Selenium IDE in one powerful tool. Enterprise-grade security and Open-Source.";
            return View();
        }


        //   [Route("~/seeshell/web-automation/webextensions")]

        //   [Route("~/welcome")]
        //     [Route("~/seeshell/web-automation/firefox/welcome")]
        [Route("~/rpa/home/welcome")]
        public ActionResult kantu_home_welcome()
        {
            return View();
        }

        //  [Route("~/seeshell/web-automation/firefox/whatsnew")]
        //  [Route("~/seeshell/web-automation/firefox/archive")]
        //[Route("~/seeshell/web-automation/firefox/why")]

        //..../chrome
        [Route("~/kantu")]
        public ActionResult kantu()
        {
            return View();
        }

        [Route("~/rpa")]
        public ActionResult rpa()
        {
            return View();
        }

        [Route("~/uivision")]
        public ActionResult uivision() { return View(); }

        [Route("~/uivision/desktop")]
        public ActionResult uivision_desktopautomation() { return View(); }

        [Route("~/desktop")]
        public ActionResult kantu_desktopautomation() { return View(); }

        [Route("~/rpa/home/getrpa")]
        public ActionResult kantu_home_getrpa() { return View(); }

        //   [Route("~/whatsnew")]
        [Route("~/rpa/home/whatsnew")]
        public ActionResult kantu_home_whatsnew() { return View();}
        [Route("~/rpa/home/whatsnew2")]
        public ActionResult kantu_home_whatsnew2() { return View(); }

        //       [Route("~/archive")]
        [Route("~/rpa/archive")]
        public ActionResult kantu_archive() { return View(); }

        [Route("~/rpa/archive2")]
        public ActionResult kantu_archive2() { return View(); }

        [Route("~/rpa/docs/ocr")]
        public ActionResult kantu_docs_ocr() { return View(); }

        //       [Route("~/why")]
        [Route("~/rpa/home/uninstallsurvey")]
        public ActionResult kantu_home_uninstallsurvey()
        {
            return View();
        }


        [Route("~/rpa/eula")]
        public ActionResult rpa_eula()
        {
            return View();
        }

        [Route("~/rpa/as400")]
        public ActionResult rpa_as400()
        {
            return View();
        }

        [Route("~/ai")]
        public ActionResult ai()
        {
            return View();
        }

        [Route("~/ai/prompt")]
        public ActionResult ai_prompt()
        {
            return View();
        }

        [Route("~/ai/screenxy")]
        public ActionResult ai_screenxy()
        {
            return View();
        }

        [Route("~/ai/computeruse")]
        public ActionResult ai_computeruse()
        {
            return View();
        }

        [Route("~/rpa/home/x/uninstallsurvey")]
        public ActionResult kantu_home_x_uninstallsurvey()
        {
            return View();
        }


        [Route("~/download")]
        public ActionResult download()
        {
            return View();
        }


        //    [Route("~/seeshell/scraping")] //diese aktiv wg SEO
        //    [Route("~/web-scraping")] //wg. SEO diese nicht benützt, erst später wieder, wenn es auch /screen-scraping gibt?
        [Route("~/seeshell/web-scraping")] //wg. SEO diese nicht benützt, erst später wieder, wenn es auch /screen-scraping gibt?
        public ActionResult seeshell_webscraping()
        {
            return View();
        }

        [Route("~/seeshell/")]
        public ActionResult seeshell()
        {
            return View();
        }

        [Route("~/seeshell/screen-scraping")]
        public ActionResult seeshell_screenscraping()
        {
            return View();
        }

  //      [Route("~/seeshell/customers")]
        [Route("~/seeshell/customers")]
        public ActionResult seeshell_customers()
        {
            return View();
        }

//        [Route("~/desktop-automation")]
        [Route("~/seeshell/desktop-automation")]
        public ActionResult seeshell_desktop() //warum geht - d..automation nicht?
        {
 ViewBag.Title = "";
            ViewBag.Description = "seeshell Desktop Automation is picture-driven Robotic Process Automation, App Testing and Screen Scraping.  Set up robotic process automation with the Kantu Browser API.";
            ViewBag.Keywords = "desktop automation, RPA,  Robotic Process Automation, computer vision, image recognition, api, OCR";
            return View();
        }


   //     [Route("~/seeshell/compare")]
        [Route("~/seeshell/compare")]
        public ActionResult seeshell_compare() 
        {
            return View();
        }

        //        [Route("~/seeshell/web-testing")]
        [Route("~/seeshell/web-testing")]
        public ActionResult seeshell_webtesting()
        {
            return View();
        }

        //[Route("~/seeshell/browser-automation")]
        [Route("~/seeshell/browser-automation")]
        public ActionResult seeshell_browserautomation()
        {
            return View();
        }

   

        [Route("~/rpa/browser-automation")] //plus redirect from seeshell on server
        public ActionResult rpa_browserautomation()
        {
            return View();
        }


        //[Route("~/seeshell/api")]
        [Route("~/seeshell/api")]
        public ActionResult seeshell_api()
        {
            return View();
        }

        //    [Route("~/")]
        //[Route("~/seeshell/web-automation")]
        [Route("~/seeshell/web-automation")]
        //    [Route("~/kantu-web-automation")]
        public ActionResult seeshell_web()
        {
   ViewBag.Title = "";
            ViewBag.Description = "Seeshell is the picture-driven Web Automation, Web Testing and Web Scraping tool.Get the free Kantu Community Edition. Or get PROm and set up robotic process automation with the Kantu Browser API.";
            ViewBag.Keywords = "form filling, web testing, data extraction, web scraping, computer vision, image recognition, api";
            return View();
        }



        [Route("~/test1")]
        public ActionResult test1()
        {
            return View();
        }


        [Route("~/test2")]
        public ActionResult test2()
        {
            return View();
        }


 //       [Route("~/eula")]
        [Route("~/seeshell/eula")]
        public ActionResult seeshell_eula()
        {
            return View();
        }

        [Route("~/seeshell/whatsnew")]
        public ActionResult seeshell_whatsnew()
        {
            return View();
        }

        //       [Route("~/download/kantupro")]
        [Route("~/download/seeshell")]
        public ActionResult download_seeshell()
        {
            return View();
        }


  //      [Route("~/download/kantu")]
        [Route("~/download/seeshell-browser")]
        public ActionResult download_seeshell_browser()
        {
            return View();
        }

/*
        [Route("~/a/download/kantu")]
        public ActionResult a_download_kantu()
        {
            return View();
        }
        */


        [Route("~/demo/")]
        public ActionResult kantu_demo()
        {
            return View();
        }

        [Route("~/demo/cleanup")]
        public ActionResult kantu_demo_cleanup() {return View(); }


        [Route("~/demo/table")]
        public ActionResult kantu_demo_table() { return View(); }

        [Route("~/seeshell/demo/multipageform")]
        public ActionResult seeshell_demo_multipageform()
        {
            return View();
        }


        [Route("~/seeshell/demo/extract")]
        public ActionResult seeshell_demo_extract()
        {
            return View();
        }

        [Route("~/demo/csvSave")] public ActionResult kantu_demo_csvSave() {return View();   }

        [Route("~/seeshell/demo/datadriven")]
        public ActionResult seeshell_demo_datadriven()
        {
            return View();
        }


        [Route("~/seeshell/demo/javascript")]
        public ActionResult seeshell_demo_javascript()
        {
            return View();
        }
        [Route("~/demo/pageloadtimeout")]
        public ActionResult kantu_demo_pageloadtimeout()
        {
            return View();
        }

        [Route("~/demo/tabs/1")]
        public ActionResult kantu_demo_tabs_1()
        {
            return View();
        }

        [Route("~/demo/tabs/2")]
        public ActionResult kantu_demo_tabs_2()
        {
            return View();
        }

        [Route("~/demo/tabs")]
        public ActionResult kantu_demo_tabs()
        {
            return View();
        }


        [Route("~/demo/draw")]
        public ActionResult kantu_demo_draw()
        {
            return View();
        }

        [Route("~/demo/xtype")]
        public ActionResult kantu_demo_xtype()
        {
            return View();
        }

        //SeeShell gets its on demo page for tabs
        [Route("~/seeshell/demo/tabs/1")]
        public ActionResult seeshell_demo_tabs_1()
        {
            return View();
        }

        [Route("~/seeshell/demo/tabs/2")]
        public ActionResult seeshell_demo_tabs_2()
        {
            return View();
        }

        [Route("~/seeshell/demo/tabs")]
        public ActionResult seeshell_demo_tabs()
        {
            return View();
        }


        [Route("~/demo/storeeval")]
        public ActionResult kantu_demo_storeeval()
        {
            return View();
        }

        [Route("~/demo/executescript")]
        public ActionResult kantu_demo_executescript()
        {
            return View();
        }



        [Route("~/demo/waitforvisible")]
        public ActionResult kantu_demo_waitforvisible()
        {
            return View();
        }


        [Route("~/demo/waitforelementvisible")]
        public ActionResult kantu_demo_waitforelementvisible()
        {
            return View();
        }

        [Route("~/demo/filedownload")]
        public ActionResult kantu_demo_filedownload()
        {
            return View();
        }

        [Route("~/seeshell/demo/flash")]
        public ActionResult seeshell_demo_flash()
        {
            return View();
        }



        [Route("~/seeshell/demo/download")]
        public ActionResult seeshell_demo_download()
        {
            return View();
        }

        [Route("~/seeshell/demo/upload")]
        public ActionResult seeshell_demo_upload()
        {
            return View();
        }

        [Route("~/seeshell/demo/clickrelative")]
        public ActionResult seeshell_demo_clickrelative()
        {
            return View();
        }


        [Route("~/seeshell/demo/relativeclick")] //alt
        public ActionResult seeshell_demo_relativeclick()
        {
            return View();
        }


        [Route("~/demo/runweb")]
        public ActionResult kantu_demo_runweb()
        {
            return View();
        }

        [Route("~/demo/runweb2")]
        public ActionResult kantu_demo_runweb2()
        {
            return View();
        }

        [Route("~/demo/runhtml")]
        public ActionResult kantu_demo_runhtml()
        {
            return View();
        }

        [Route("~/seeshell/demo/scroll")]
        public ActionResult seeshell_demo_scroll()
        {
            return View();
        }


        [Route("~/seeshell/demo/draw")]
        public ActionResult seeshell_demo_draw()
        {
            return View();
        }

        [Route("~/seeshell/demo/flightsearch")]
        public ActionResult seeshell_demo_flightsearch()
        {
            return View();
        }


        [Route("~/demo/iframes")]
        public ActionResult kantu_demo_iframes()
        {
            return View();
        }

        [Route("~/demo/canvas")]
        public ActionResult kantu_demo_canvas()
        {
            return View();
        }


        [Route("~/store")]
        public ActionResult store()
        {
            return View();
        }

        [Route("~/store2")]
        public ActionResult store2()
        {
            return View();
        }

        [Route("~/store/order31988")]
        public ActionResult store_order31988()
        {
           return View();
        }

        [Route("~/rpa/x")]
        public ActionResult kantu_x(){return View();}

        [Route("~/rpa/x/desktop-automation")]
        public ActionResult kantu_x_desktopautomation() { return View(); }

        [Route("~/rpa/x/desktop-automation/screen-scraping")]
        public ActionResult kantu_x_da_screenscraping() { return View(); }

        [Route("~/rpa/x/rpa")] //use it?
        public ActionResult kantu_x_rpa() { return View(); }

        [Route("~/rpa/x/customers")] //use it?
        public ActionResult kantu_x_customers() { return View(); }

        [Route("~/rpa/x/pro")]
        public ActionResult kantu_x_pro() { return View(); }

        [Route("~/rpa/x/pricing")]
        public ActionResult kantu_x_pricing() { return View(); }

        [Route("~/rpa/x/calibrate")]
        public ActionResult kantu_x_calibrate() { return View(); }

        [Route("~/rpa/x/pricing2")]
        public ActionResult kantu_x_pricing2() { return View(); }

        [Route("~/rpa/x/download")]
        public ActionResult kantu_x_download() {return View();}

        [Route("~/rpa/home/x")]
        public ActionResult kantu_home_x() {return View();}

        [Route("~/rpa/docs/xclick")]
        public ActionResult kantu_docs_xclick() {return View();}


        //[Route("~/rpa/docs/x/xmove")]
        //public ActionResult kantu_docs_x_xmove() { return View(); }


        [Route("~/rpa/docs/xtype")]
        public ActionResult kantu_docs_xtype() { return View(); }


        [Route("~/rpa/docs/firefox")]
        public ActionResult kantu_docs_firefox() { return View(); }


        [Route("~/seeshell/docs")]
        public ActionResult seeshell_docs()
        {
            return View();
        }

        //TMP BIS ALLES RENAMED
        /*
        [Route("~/rpa/docs")]
        public ActionResult kantu_docsTMP()
        {
            return View();
        }*/

        [Route("~/seeshell/flash")]
        public ActionResult seeshell_flash()
        {
            return View();
        }

        [Route("~/rpa/flash")]
        public ActionResult kantu_flash()
        {
            return View();
        }

        //[Route("~/seeshell/docs/scraping")]
        [Route("~/seeshell/docs/scraping")]
        public ActionResult seeshell_docs_scraping()
        {
            return View();
        }

        [Route("~/howto/purchase-order")]
        public ActionResult howto_po()
        {
            return View();
        }

        [Route("~/howto/taskscheduler")]
        public ActionResult howto_taskscheduler()
        {
            return View();
        }
        [Route("~/howto/getseleniumide")]
        public ActionResult howto_getseleniumide()
        {
            return View();
        }

        [Route("~/howto/view-local-storage")]
        public ActionResult howto_viewlocalstorage()
        {
            return View();
        }

        [Route("~/howto/install-chrome-extension-from-file")]
        public ActionResult howto_installchromeextensionfromfile()
        {
            return View();
        }

        [Route("~/sikuli")]
        public ActionResult sikuli()
        {
            return View();
        }
        [Route("~/sikuli/autoit")]
        public ActionResult sikuli_autoit()
        {
            return View();
        }
        [Route("~/sikuli/selenium")]
        public ActionResult sikuli_selenium()
        {
            return View();
        }
     
        [Route("~/sikuli/autohotkey")]
        public ActionResult sikuli_autohotkey()
        {
            return View();
        }
        [Route("~/sikuli/applitools")]
        public ActionResult sikuli_applitools()
        {
            return View();
        }
        [Route("~/sikuli/opencv")]
        public ActionResult sikuli_opencv()
        {
            return View();
        }


        //*******************************************************************************
        // BEI Änderunge hier immer auch die DLLn im /BIN foler updaten 
        //*******************************************************************************




        [Route("~/seeshell/home/welcome")]
        public ActionResult seeshell_home_welcome()
        {
            return View();
        }

        [Route("~/seeshell/home/")]
        public ActionResult seeshell_home()
        {
            return View();
        }

        [Route("~/seeshell/home/pro")]
        public ActionResult seeshell_home_pro()
        {
            return View();
        }

        [Route("~/seeshell/home/uninstallsurvey")]
        public ActionResult seeshell_home_uninstallsurvey()
        {
            return View();
        }

        //BROWSER, OLd home pages

        [Route("~/seeshell/browser/home/kantux")]
        public ActionResult seeshell_browser_home_kantux()
        {
            return View();
        }

        [Route("~/seeshell/browser/home/kantuxpro")]
        public ActionResult seeshell_browser_home_kantuxpro()
        {
            return View();
        }

        //BROWSER

        [Route("~/seeshell/browser/home/welcome")]
        public ActionResult seeshell_browser_home_welcome()
        {
            return View();
        }


        [Route("~/seeshell/browser/home")]
        public ActionResult seeshell_browser_home()
        {
            return View();
        }

        [Route("~/seeshell/browser/home/pro")]
        public ActionResult seeshell_browser_home_pro()
        {
            return View();
        }

        [Route("~/seeshell/browser/home/uninstallsurvey")]
        public ActionResult seeshell_browser_home_uninstallsurvey()
        {
            return View();
        }

        [Route("~/seeshell/browser")]
        public ActionResult seeshell_browser()
        {
            return View();
        }





        [Route("~/colorfish/welcome")] 
        public ActionResult colorfish_welcome()  {  return View(); }

        [Route("~/colorfish/whatsnew")]
        public ActionResult colorfish_whatsnew() { return View(); }

        [Route("~/colorfish/why")]
        public ActionResult colorfish_why() { return View(); }

        [Route("~/colorfish/")]
        public ActionResult colorfish()
        {
            return View();
        }

        [Route("~/colorfish/docs")]
        public ActionResult colorfish_docs()
        {
            return View();
        }


        /// <summary>
        // about
        /// </summary>
        /// <returns>View</returns>
        [Route("~/About")]
        public ActionResult About()
        {
            return View();
        }

        /// <summary>
        /// contact us
        /// </summary>
        /// <returns>View</returns>
        [Route("~/contact")]
        public ActionResult contact()
        {
            return View();
        }

        [Route("~/newsletter")]
        public ActionResult newsletter()
        {
            return View();
        }


        [Route("~/newsletter/thankyou")]
        public ActionResult newsletter_thankyou()
        {
            return View();
        }

        [Route("~/newsletter/almostfinished")]
        public ActionResult newsletter_almostfinished()
        {
            return View();
        }


        //Selenium XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        [Route("~/rpa/docs/")]
          public ActionResult kantu_docs() { return View(); }


      
        [Route("~/rpa/docs/selenium-ide/")]
        public ActionResult kantu_docs_seleniumide()  { return View();  }

        [Route("~/rpa/docs/selenium-ide/locators")]
        public ActionResult kantu_docs_seleniumide_locators() { return View(); }

        [Route("~/rpa/docs/selenium-ide/web-scraping")]
        public ActionResult kantu_docs_seleniumide_webscraping() { return View(); }

        [Route("~/rpa/docs/selenium-ide/form-filling")]
        public ActionResult kantu_docs_seleniumide_formfilling() { return View(); }


        [Route("~/rpa/docs/selenium-ide/answerOnNextPrompt")]
        public ActionResult kantu_docs_seleniumide_answerOnNextPrompt() { return View(); }

        [Route("~/rpa/docs/selenium-ide/assertAlert-assertConfirmation-assertPrompt")]
        public ActionResult kantu_docs_seleniumide_assertAlertassertConfirmationassertPrompt() { return View(); }

        [Route("~/rpa/docs/selenium-ide/command-deprecated")]
        public ActionResult kantu_docs_seleniumide_commanddeprecated() { return View(); }

        [Route("~/rpa/docs/selenium-ide/asserteditable")]
        public ActionResult kantu_docs_seleniumide_asserteditable() { return View(); }

        [Route("~/rpa/docs/selenium-ide/assertElementPresent-verifyElementPresent")]
        public ActionResult kantu_docs_seleniumide_assertElementPresentverifyElementPresent() { return View(); }


        [Route("~/rpa/docs/selenium-ide/assertText-verifytext")]
        public ActionResult kantu_docs_seleniumide_asserttextverifytext() { return View(); }


        [Route("~/rpa/docs/selenium-ide/assertTitle-verifyTitle")]
        public ActionResult kantu_docs_seleniumide_asserttitleverifytitle() { return View(); }

        [Route("~/rpa/docs/selenium-ide/assertvalue-verifyvalue")]
        public ActionResult kantu_docs_seleniumide_assertvalueverifyvalue() { return View(); }

        [Route("~/rpa/docs/selenium-ide/captureScreenshot")]
        public ActionResult kantu_docs_seleniumide_captureScreenshot() { return View(); }

        [Route("~/rpa/docs/selenium-ide/check-uncheck")]
        public ActionResult kantu_docs_seleniumide_checkuncheck() { return View(); }

        [Route("~/rpa/docs/selenium-ide/click")]
        public ActionResult kantu_docs_seleniumide_click() { return View(); }

        [Route("~/rpa/docs/selenium-ide/bringbrowsertoforeground")]
        public ActionResult kantu_docs_seleniumide_bringbrowsertoforeground() { return View(); }

        [Route("~/rpa/docs/selenium-ide/comment")]
        public ActionResult kantu_docs_seleniumide_comment() { return View(); }


        [Route("~/rpa/docs/selenium-ide/resize")]
        public ActionResult kantu_docs_seleniumide_resize() { return View(); }

        [Route("~/rpa/docs/selenium-ide/run")]
        public ActionResult kantu_docs_seleniumide_run() { return View(); }


        [Route("~/rpa/docs/xrun")]
        public ActionResult kantu_docs_xrun() { return View(); }


        [Route("~/rpa/docs/visual-ui-testing")]
        public ActionResult kantu_docs_visualuitesting() { return View(); }

        [Route("~/rpa/docs/selenium-ide/highlight")]
        public ActionResult kantu_docs_seleniumide_highlight() { return View(); }

        [Route("~/rpa/docs/selenium-ide/clickAt")]
        public ActionResult kantu_docs_seleniumide_clickAt() { return View(); }

        [Route("~/rpa/docs/selenium-ide/csvSave")]
        public ActionResult kantu_docs_seleniumide_csvSave() { return View(); }

        [Route("~/rpa/docs/selenium-ide/csvread")]
        public ActionResult kantu_docs_seleniumide_csvread() { return View(); }


        [Route("~/rpa/docs/selenium-ide/deleteAllVisibleCookies")]
        public ActionResult kantu_docs_seleniumide_deleteAllVisibleCookies() { return View(); }


        [Route("~/rpa/docs/selenium-ide/deleteAllCookies")]
        public ActionResult kantu_docs_seleniumide_deleteAllCookies() { return View(); }

        [Route("~/rpa/docs/selenium-ide/dragAndDropToObject")]
        public ActionResult kantu_docs_seleniumide_dragAndDropToObject() { return View(); }

        [Route("~/rpa/docs/selenium-ide/echo")]
        public ActionResult kantu_docs_seleniumide_echo() { return View(); }

        [Route("~/rpa/docs/selenium-ide/editcontent")]
        public ActionResult kantu_docs_seleniumide_editcontent() { return View(); }

        [Route("~/rpa/docs/selenium-ide/executescript")]
        public ActionResult kantu_docs_seleniumide_executescript() { return View(); }

        [Route("~/rpa/docs/selenium-ide/executeasyncscript")]
        public ActionResult kantu_docs_seleniumide_executeasyncscript() { return View(); }

        [Route("~/rpa/docs/selenium-ide/times")]
        public ActionResult kantu_docs_seleniumide_times() { return View(); }

        [Route("~/rpa/docs/selenium-ide/foreach")]
        public ActionResult kantu_docs_seleniumide_foreach() { return View(); }


        [Route("~/rpa/docs/selenium-ide/if")]
        public ActionResult kantu_docs_seleniumide_if() { return View(); }

        [Route("~/rpa/docs/selenium-ide/gotoif")]
        public ActionResult kantu_docs_seleniumide_gotoif() { return View(); }

        [Route("~/rpa/docs/selenium-ide/gotolabel")]
        public ActionResult kantu_docs_seleniumide_gotolabel() { return View(); }

        [Route("~/rpa/docs/selenium-ide/label")]
        public ActionResult kantu_docs_seleniumide_label() { return View(); }

        [Route("~/rpa/docs/selenium-ide/mouseOver")]
        public ActionResult kantu_docs_seleniumide_mouseOver() { return View(); }

        [Route("~/rpa/docs/selenium-ide/open")]
        public ActionResult kantu_docs_seleniumide_open() { return View(); }

        [Route("~/rpa/docs/selenium-ide/pause")]
        public ActionResult kantu_docs_seleniumide_pause() { return View(); }

        [Route("~/rpa/docs/selenium-ide/localstorageexport")]
        public ActionResult kantu_docs_seleniumide_localstorageexport() { return View(); }



        [Route("~/rpa/docs/selenium-ide/refresh")]
        public ActionResult kantu_docs_seleniumide_refresh() { return View(); }


        [Route("~/rpa/docs/selenium-ide/select")]
        public ActionResult kantu_docs_seleniumide_select() { return View(); }

        [Route("~/rpa/docs/selenium-ide/selectFrame")]
        public ActionResult kantu_docs_seleniumide_selectFrame() { return View(); }

        [Route("~/rpa/docs/selenium-ide/selectWindow")]
        public ActionResult kantu_docs_seleniumide_selectWindow() { return View(); }

        [Route("~/rpa/docs/selenium-ide/setwindowsize")]
        public ActionResult kantu_docs_seleniumide_setwindowsize() { return View(); }

        [Route("~/rpa/docs/selenium-ide/setproxy")]
        public ActionResult kantu_docs_seleniumide_setproxy() { return View(); }

        [Route("~/rpa/docs/selenium-ide/sendKeys-type")]
        public ActionResult kantu_docs_seleniumide_sendKeystype() { return View(); }


        [Route("~/rpa/docs/selenium-ide/sourceExtract-sourceSearch")]
        public ActionResult kantu_docs_seleniumide_sourceExtractsourceSearch() { return View(); }


        [Route("~/rpa/docs/selenium-ide/store")]
        public ActionResult kantu_docs_seleniumide_store() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storedVars")]
        public ActionResult kantu_docs_seleniumide_storedVars() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storeattribute")]
        public ActionResult kantu_docs_seleniumide_storeattribute() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storeEval")]
        public ActionResult kantu_docs_seleniumide_storeEval() { return View(); }

   

        [Route("~/rpa/docs/selenium-ide/storeimage")]
        public ActionResult kantu_docs_seleniumide_storeimage() { return View(); }

        [Route("~/rpa/docs/selenium-ide/saveitem")]
        public ActionResult kantu_docs_seleniumide_saveitem() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storeText")]
        public ActionResult kantu_docs_seleniumide_storeText() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storeTitle")]
        public ActionResult kantu_docs_seleniumide_storeTitle() { return View(); }


        [Route("~/rpa/docs/selenium-ide/storeValue")]
        public ActionResult kantu_docs_seleniumide_storevalue() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storexpathcount")]
        public ActionResult kantu_docs_seleniumide_storexpathcount() { return View(); }

        [Route("~/rpa/docs/selenium-ide/storechecked")] public ActionResult kantu_docs_seleniumide_storechecked() { return View(); }
        [Route("~/rpa/docs/selenium-ide/assertchecked-verifychecked")] public ActionResult kantu_docs_seleniumide_assertcheckedverifychecked() { return View(); }


        [Route("~/rpa/docs/selenium-ide/WaitForElementPresent")]
        public ActionResult kantu_docs_seleniumide_WaitForElementPresent() { return View(); }

        [Route("~/rpa/docs/selenium-ide/WaitForVisible")]
        public ActionResult kantu_docs_seleniumide_WaitForVisible() { return View(); }

        [Route("~/rpa/docs/selenium-ide/WaitForElementVisible")]
        public ActionResult kantu_docs_seleniumide_WaitForElementVisible() { return View(); }

        [Route("~/rpa/docs/selenium-ide/waitForPageToLoad")]
        public ActionResult kantu_docs_seleniumide_waitForPageToLoad() { return View(); }

        [Route("~/rpa/docs/selenium-ide/do-repeatif")]
        public ActionResult kantu_docs_seleniumide_do_repeatif() { return View(); }


        [Route("~/rpa/docs/selenium-ide/addselection-removeselection")]
        public ActionResult kantu_docs_seleniumide_addselection_removeselection() { return View(); }


        [Route("~/rpa/docs/selenium-ide/while")]
        public ActionResult kantu_docs_seleniumide_while() { return View(); }

        [Route("~/rpa/docs/selenium-ide/end")]
        public ActionResult kantu_docs_seleniumide_end() { return View(); }

        [Route("~/rpa/docs/selenium-ide/oldfirefoxide")]
        public ActionResult kantu_docs_seleniumide_oldfirefoxide() { return View(); }

        [Route("~/rpa/docs/sidepanel")]
        public ActionResult kantu_docs_sidepanel() { return View(); }

        [Route("~/rpa/migrate/imacros")]
        public ActionResult kantu_docs_imacros() { return View(); }


        /// <summary>
        /// Contact POST page
        /// </summary>
        /// <param name="contactViewModel">Contact view model</param>
        /// <returns>View</returns>
        [HttpPost]
        [Route("~/contact")]
        public ActionResult Contact(ContactViewModel contactViewModel)
        {
            string ipAddress = Request.ServerVariables["REMOTE_ADDR"] + " , ";

            if(ModelState.IsValid)
            {
                try
                {
                    /*Logger.Info(ipAddress + "Contact Request");
                    Logger.Info(ipAddress + "Name: " + contactViewModel.ContactName);
                    Logger.Info(ipAddress + "Mail: " + contactViewModel.Email);
                    Logger.Info(ipAddress + "Sub: " + contactViewModel.Subject);
                    Logger.Info(ipAddress + "Message: " + contactViewModel.Message);
                    */

                    string smtpServer = ConfigurationManager.AppSettings["smtpServer"];
                    int smtpServerPort = Convert.ToInt32(ConfigurationManager.AppSettings["smtpServerPort"]);
                    bool enableSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["enableSSL"]);
                    string fromEmail = ConfigurationManager.AppSettings["fromEmail"];
                    string fromEmailPassword = ConfigurationManager.AppSettings["fromEmailPassword"];
                    string toEmail = ConfigurationManager.AppSettings["toEmail"];

                    //If there are no errors, then drop an email to the owner using the SMTP credentials from web.config
                    var client = new SmtpClient(smtpServer, smtpServerPort)
                    {
                        EnableSsl = enableSSL,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromEmail, fromEmailPassword),
                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };

                    string messageBody = "<html><body>" +
                        "<p>New Kantu contact form submission:</p>" +
                        "<p><span><bold>Name:&nbsp;</bold></span>" + contactViewModel.ContactName + "</p>" +
                        "<p><span><bold>Email:&nbsp;</bold></span>" + contactViewModel.Email + "</p>" +
 "<p><span><bold>Software:&nbsp;</bold></span>" + contactViewModel.WhatSoftware + "</p>" +
                        "<p><span><bold>Message:&nbsp;</bold></span>" + contactViewModel.Message.Replace("\r\n", "<br>") + "</p>" +
                        "</body></html>";

                    MailMessage message = new MailMessage();
                    message.IsBodyHtml = true;
                    message.Body = messageBody;
                    message.From = new MailAddress(fromEmail);
                    message.ReplyTo = new MailAddress(contactViewModel.Email);
                    message.To.Add(new MailAddress(toEmail));
                    message.Subject = "Contact form: " + contactViewModel.Subject;
                    client.Send(message);

                    ModelState.Clear();

                    ViewBag.IsSuccessfulMessageDelivery = true;

                    //Logger.Info("Contact mail sent successfully!");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Unable to send contact request. Please try again later.");
                    //Logger.Error(ipAddress + "Error occurred when processing contact us request. Error message: " + ex.Message);
                    //Logger.Error(ex);
                }
            }
            return View();
        }


        /// <summary>
        /// faq
        /// </summary>
        /// <returns>View</returns>
        [Route("~/faq")]
        public ActionResult faq()
        {
            return View();
        }



     
        /// <summary>
        ///PP
        /// </summary>
        /// <returns>View</returns>
        [Route("~/privacypolicy")]
        public ActionResult privacypolicy()
        {
            return View();
        }

        //*********************************************************************

            //KANTUX ALT
        [Route("~/x/k")] //TODO: new redir for seeshell and ss browser
        public ActionResult x_k()
        {

            //TEST:  https://ui.vision/rpa/x/k?v=2.0.1.0B111CXX
            //                                                                               "2.0.5.0B111CXX"; //free version, api not used, non-adwords
            //http://localhost:3437/x/k?kantu=Hello&m1=GettingStarted&m2=CheckingForUpdates&v=2.2.3.0B190RBX
            var s = "";
            s = Request.QueryString["v"];

            var homeurl = "https://ui.vision/";

            string logpath = ConfigurationManager.AppSettings["logfilelocation"];



            string ip = Request.UserHostAddress;
            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {   //ERSTER TEIL HIER; 2ter teil BEI ERFOLG UNTEN
                w.Write("\r\n{0},{1},{2},{3},", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ip, s);
            }

            if (s == null) return View();

            //v=2.04.4B111XYZ

            if (!s.Contains("B")) return Redirect(homeurl);

            var sa = s.Split('B');
            var sb = sa[1];

            if (sb.Length != 6) return Redirect(homeurl);

            var vinstalled = sa[0];

            string vlatest = "2.2.1.0";

            var vi = new Version(vinstalled);
            var vl = new Version(vlatest);

            bool UpgradeAvail = false;
            bool IsApiActive = false;
            bool IsAdwords = false;
            bool IsFree = false;
            bool IsProTrial = false;
            bool IsPro = false;

            var result = vl.CompareTo(vi);
            if (result > 0) UpgradeAvail = true;

            s = sb.Substring(3, 1);
            if (s != "C" && s != "P" && s != "R") return Redirect(homeurl);
            if (s == "C") IsFree = true;
            if (s == "P") IsProTrial = true;
            if (s == "R") IsPro = true;
            var sType = s; //für log

            s = sb.Substring(4, 1);
            if (s != "X" && s != "A" && s != "1" && s != "5") return Redirect(homeurl);
            if (s == "A" || s == "1" || s == "5") IsApiActive = true; //s == "A" ist alt noch nicht benutzt! 
            var sApi = s; //für log

            s = sb.Substring(5, 1);
            if (s != "X" && s != "A") return Redirect(homeurl);
            if (s == "A") IsAdwords = true;
            var sAdwords = s; //für log

            var days = 0;
            if (!Int32.TryParse(sb.Substring(0, 3), out days)) days = -1;
            days -= 110;



            //date, time, ip, version, free/pro/reg, API, Adwords

            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {  //ZWEITER TEIL!
                w.Write("{0},{1},{2},{3},{4}", sType, days, vinstalled, sApi, sAdwords);

            }

            //build url
            var url = "https://ui.vision/seeshell/browser/home/kantux";

            if (IsPro) url = "http://ui.vision/seeshell/browser/home/kantuxpro";
            if (IsProTrial) url = "http://ui.vision/seeshell/browser/home/kantux";

            if (UpgradeAvail) url = url + "?info=updateavailable";


            return Redirect(url);
            //         System.IO.File.AppendAllText(@"c:\path\file.txt", "text content" + Environment.NewLine);



            return View();
        }

        //seeshell!
        [Route("~/x/s")] //TODO: new redir for seeshell and ss browser
        public ActionResult x_s()
        {

            //TEST:  https://ui.vision/rpa/x/s?v=2.0.1.0B111CXX
            //                                                                               "2.0.5.0B111CXX"; //free version, api not used, non-adwords
            //2 b?? => errror                     http://localhost:3437/x/s?seeshell=desktop&kantu=Hello&m1=GettingStarted&m2=CheckingForUpdates&v=2.2.3.0B190RBX

            // http://localhost:3437/x/s?seeshell=desktop&m1=GettingStarted&m2=CheckingForUpdates&v=2.2.3.0B190RXX
            // https://ui.vision/rpa/x/s?SeeShell=Browser&m1=GettingStarted&m2=CheckingForUpdates&v=3.1.0.0B111RXX
            var s = "";
            s = Request.QueryString["v"];
            var sdeskorweb = Request.QueryString["seeshell"];
            var homeurl = "https://ui.vision/";
            
            string logpath = ConfigurationManager.AppSettings["logfilelocationseeshell"];



            string ip = Request.UserHostAddress;
            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {   //ERSTER TEIL HIER; 2ter teil BEI ERFOLG UNTEN
                w.Write("\r\n{0},{1},{2},{3},", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ip, s);
            }

            if (s == null) return View();

            //v=2.04.4B111XYZ

            if (!s.Contains("B")) return Redirect(homeurl);

            var sa = s.Split('B');
            var sb = sa[1];

            if (sb.Length != 6) return Redirect(homeurl);

            var vinstalled = sa[0];

            string vlatest = "3.3.0.3";

            var vi = new Version(vinstalled);
            var vl = new Version(vlatest);

            bool UpgradeAvail = false;
            bool IsApiActive = false;
            bool IsAdwords = false;
            bool IsFree = false;
            bool IsProTrial = false;
            bool IsPro = false;

            var result = vl.CompareTo(vi);
            if (result > 0) UpgradeAvail = true;

            s = sb.Substring(3, 1);
            if (s != "C" && s != "P" && s != "R") return Redirect(homeurl);
            if (s == "C") IsFree = true;
            if (s == "P") IsProTrial = true;
            if (s == "R") IsPro = true;
            var sType = "--";
            sType = s; //für log

            s = sb.Substring(4, 1);
            if (s != "X" && s != "A" && s != "1" && s != "5") return Redirect(homeurl);
            if (s == "A" || s == "1" || s == "5") IsApiActive = true; //s == "A" ist alt noch nicht benutzt! 
            var sApi = s; //für log

/*            s = sb.Substring(5, 1);
            if (s != "X" && s != "A") return Redirect(homeurl);
            if (s == "A") IsAdwords = true;
            var sAdwords = s; //für log
*/
            var days = 0;
            if (!Int32.TryParse(sb.Substring(0, 3), out days)) days = -1;
            days -= 110;



            //date, time, ip, version, free/pro/reg, API, Adwords

            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {  //ZWEITER TEIL!
                w.Write("{0},{1},{2},{3},{4}", sdeskorweb, sType, days, vinstalled, sApi);

            }

            //build url
            var url ="";
            if (sdeskorweb == "desktop" || sdeskorweb == "Desktop")
            {
                 url = "https://ui.vision/seeshell/home";
                if (IsPro) url = "http://ui.vision/seeshell/home/pro";
                if (UpgradeAvail) url = url + "?info=updateavailable";
            }
            else
            {
                 url = "https://ui.vision/seeshell/browser/home";
                if (IsPro) url = "http://ui.vision/seeshell/browser/home/pro";
                if (UpgradeAvail) url = url + "?info=updateavailable";
            }

            //zur Zeit nur für WEB (Ausnahme!) if (UpgradeAvail) url = url + "?info=updateavailable";


            return Redirect(url);
            //         System.IO.File.AppendAllText(@"c:\path\file.txt", "text content" + Environment.NewLine);



            return View();
        }


        [Route("~/x/idehelp")]
        public ActionResult x_idehelp()
        {

            //TEST:  https://ui.vision/rpa/x/idehelp?cmd=capturescreenshot
            //TEST:  https://ui.vision/rpa/x/idehelp?cmd=asserttext
            //TEST:  https://ui.vision/rpa/x/idehelp?cmd=type
            //TEST:  https://ui.vision/rpa/x/idehelp?cmd=NOTFOUNDxxx

            //TEST:  https://ui.vision/rpa/x/idehelp?help=timeout_macro


            //http://localhost:3437/x/idehelp?cmd=capturescreenshot
            var s = "";
            s = Request.QueryString["cmd"];

            var shelp = "";
            shelp = Request.QueryString["help"];

            var url1 = "https://ui.vision/rpa/docs/selenium-ide/";
            var urldocs = "https://ui.vision/rpa/docs/";//unused?!

            string logpath = ConfigurationManager.AppSettings["logfilelocationidehelp"];

            string ip = Request.UserHostAddress;
            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {   //NUR HIER; 
                w.Write("\r\n{0},{1},{2},{3},", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ip, s);
            }

            /************
             * 
             * 
             * 
             * assertEditable + NOT, verifyEditable + NOT
assertElementNotPresent => got to 
assertNotChecked => +++, verifynotchecked++++ o
check ooooooo
clickandwait!!! "andwait" ooooooooo
elseif - just link
_deprecated!!!!!!!ooooooo
endwhile add _deprecated
ex
ex_sandbox oooooooooo
DOCS PAGE BROKEN??? OKKKKKK
OCR.. alle futsch?
https://ui.vision/rpa/x/desktop-automation/screen-scraping#docs
https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrextractrelative

            https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrsearch

selectandwait id=selectandwait

storeattribute => nur link
uncheck ok

verifyelementnotpresent +++

visualassert => better link id=visualassert
             * */

            //Doch noch hier, dann use DLL für GOTO.ui.Vision!!!

            if (s != null)
            {
                //deprecated commands
                if (s.Equals("storeeval")) return Redirect(url1 + "storeeval");
       //         if (s.Equals("while")) return Redirect(url1 + "command-deprecated");
       //         if (s.Equals("if")) return Redirect(url1 + "command-deprecated");
                if (s.Equals("resize")) return Redirect(url1 + "command-deprecated");
        //        if (s.Equals("gotoif")) return Redirect(url1 + "command-deprecated");
                if (s.Equals("endif")) return Redirect(url1 + "command-deprecated");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!!

                //diese vor click contains
                if (s.Equals("xclick")) return Redirect("https://ui.vision/rpa/docs/xclick");
                if (s.Equals("xmove")) return Redirect("https://ui.vision/rpa/docs/xclick");
                if (s.Equals("xtype")) return Redirect("https://ui.vision/rpa/docs/xtype");

                if (s.Equals("xclickrelative")) return Redirect("https://ui.vision/rpa/docs/xclick#relative");
                if (s.Equals("xmoverelative")) return Redirect("https://ui.vision/rpa/docs/xclick#relative");

                if (s.Equals("xclicktext")) return Redirect("https://ui.vision/rpa/docs/xclick#xclicktext");
                if (s.Equals("xmovetext")) return Redirect("https://ui.vision/rpa/docs/xclick#xmovetext");
                if (s.Equals("xclicktextrelative")) return Redirect("https://ui.vision/rpa/docs/xclick#xclicktextrelative");
                if (s.Equals("xmovetextrelative")) return Redirect("https://ui.vision/rpa/docs/xclick#xmovetextrelative");
                if (s.Equals("ocrextractbytextrelative")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrextractbytextrelative");

                if (s.Equals("check")) return Redirect(url1 + "check-uncheck");
                if (s.Equals("uncheck")) return Redirect(url1 + "check-uncheck");

                if (s.Equals("clickat")) return Redirect(url1 + s);
                if (s.Equals("csvread")) return Redirect(url1 + s);
                if (s.Equals("csvsave")) return Redirect(url1 + s);
                if (s.Equals("deleteallcookies")) return Redirect(url1 + s);
                if (s.Equals("answeronnextprompt")) return Redirect(url1 + s);
                if (s.Equals("draganddroptoobject")) return Redirect(url1 + s);
                if (s.Equals("echo")) return Redirect(url1 + s);

                if (s.Equals("executescript")) return Redirect(url1 + s);
                if (s.Equals("executescript_sandbox")) return Redirect(url1 + "executescript#sandbox");
                if (s.Equals("executeasyncscript")) return Redirect(url1 + s);
                if (s.Equals("executeasyncscript_sandbox")) return Redirect(url1 + "executeasyncscript#sandbox");

                if (s.Equals("gotoif_v2")) return Redirect(url1 +"gotoif");
                if (s.Equals("gotoif")) return Redirect(url1 + "gotoif");

                if (s.Equals("gotolabel")) return Redirect(url1 + s);
                if (s.Equals("label")) return Redirect(url1 + s);
                if (s.Equals("open")) return Redirect(url1 + s);
                if (s.Equals("openbrowser")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/open#openbrowser");
                if (s.Equals("mouseover")) return Redirect(url1 + s);
                if (s.Equals("pause")) return Redirect(url1 + s);
                if (s.Equals("refresh")) return Redirect(url1 + s);
                if (s.Equals("storeeval")) return Redirect(url1 + s);
                if (s.Equals("selectframe")) return Redirect(url1 + s);
                if (s.Equals("selectwindow")) return Redirect(url1 + s);
                if (s.Equals("setwindowsize")) return Redirect(url1 + s);
                if (s.Equals("setproxy")) return Redirect(url1 + s);
                if (s.Equals("store")) return Redirect(url1 + s);
                if (s.Equals("storetext")) return Redirect(url1 + s);
                if (s.Equals("storetitle")) return Redirect(url1 + s);
                if (s.Equals("storevalue")) return Redirect(url1 + s);
                if (s.Equals("storeattribute")) return Redirect(url1 + s);
                if (s.Equals("storechecked")) return Redirect(url1 + s);
                if (s.Equals("waitforpagetoload")) return Redirect(url1 + s);
                if (s.Equals("capturescreenshot")) return Redirect(url1 + s);

                if (s.Equals("storexpathcount")) return Redirect(url1 + s);

                                if (s.Equals("capturescreenshot")) return Redirect(url1 + s);
                if (s.Equals("captureentirepagescreenshot")) return Redirect(url1 + "capturescreenshot");

                //if (s.Equals("while")) return Redirect(url1 + s);
                if (s.Equals("while_v2")) return Redirect(url1 + "while");
                if (s.Equals("while")) return Redirect(url1 + "while");
                if (s.Equals("end")) return Redirect(url1 + "end");
                if (s.Equals("endif")) return Redirect(url1 + "end");
                if (s.Equals("endwhile")) return Redirect(url1 + "end");

            //    if (s.Equals("if")) return Redirect(url1 + "if"); //contains => auch für endif und verifytext matches
                if (s.Equals("if_v2")) return Redirect(url1 + "if"); //contains => auch für endif und verifytext matches
                if (s.Equals("if")) return Redirect(url1 + "if"); //contains => auch für endif und verifytext matches
                                                                     //    if (s.Equals("else")) return Redirect(url1 + "if");
                if (s.Equals("elseif")) return Redirect(url1 + "if");
                if (s.Equals("elseif_v2")) return Redirect(url1 + "if");
                if (s.Equals("endif")) return Redirect(url1 + "if");

                if (s.Equals("asserteditable")) return Redirect(url1 + "asserteditable");
                if (s.Equals("assertnoteditable")) return Redirect(url1 + "asserteditable#not");
                if (s.Equals("verifyeditable")) return Redirect(url1 + "asserteditable");
                if (s.Equals("verifynoteditable")) return Redirect(url1 + "asserteditable#not");

                if (s.Equals("assertchecked")) return Redirect(url1 + "assertchecked-verifychecked");
                if (s.Equals("verifychecked")) return Redirect(url1 + "assertchecked-verifychecked");
                if (s.Equals("assertnotchecked")) return Redirect(url1 + "assertchecked-verifychecked#not");
                if (s.Equals("verifynotchecked")) return Redirect(url1 + "assertchecked-verifychecked#not");

                if (s.Equals("assertelementpresent")) return Redirect(url1 + "assertelementpresent-verifyelementpresent");
                if (s.Equals("verifyelementpresent")) return Redirect(url1 + "assertelementpresent-verifyelementpresent");
                if (s.Equals("assertelementnotpresent")) return Redirect(url1 + "assertelementpresent-verifyelementpresent#not");
                if (s.Equals("verifyelementnotpresent")) return Redirect(url1 + "assertelementpresent-verifyelementpresent#not");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!! 

                if (s.Equals("asserttext")) return Redirect(url1 + "asserttext-verifytext");
                if (s.Equals("verifytext")) return Redirect(url1 + "asserttext-verifytext");

                if (s.Equals("assertvalue")) return Redirect(url1 + "assertvalue-verifyvalue");
                if (s.Equals("verifyvalue")) return Redirect(url1 + "assertvalue-verifyvalue");

                if (s.Equals("verifytext")) return Redirect(url1 + "asserttext-verifytext");

                if (s.Equals("asserttitle")) return Redirect(url1 + "asserttitle-verifytitle");
                if (s.Equals("verifytitle")) return Redirect(url1 + "asserttitle-verifytitle");

                if (s.Equals("assertalert")) return Redirect(url1 + "assertalert-assertconfirmation-assertprompt");
                if (s.Equals("assertconfirmation")) return Redirect(url1 + "assertalert-assertconfirmation-assertprompt");
                if (s.Equals("assertprompt")) return Redirect(url1 + "assertalert-assertconfirmation-assertprompt");

                if (s.Equals("assert")) return Redirect("https://ui.vision/rpa/docs/selenium-ide#assert");
                if (s.Equals("verify")) return Redirect("https://ui.vision/rpa/docs/selenium-ide#verify");

                if (s.Equals("click")) return Redirect(url1 + "click");
                if (s.Equals("clickAndWait")) return Redirect(url1 + "click#clickandwait");

                if (s.Equals("select")) return Redirect(url1 + "select");
                if (s.Equals("selectAndWait")) return Redirect(url1 + "select#selectandwait");

                if (s.Equals("sendkeys")) return Redirect(url1 + "sendkeys-type");
                if (s.Equals("type")) return Redirect(url1 + "sendkeys-type");

                if (s.Equals("ondownload")) return Redirect("https://ui.vision/rpa/docs#ondownload");
                if (s.Equals("throwerror")) return Redirect("https://ui.vision/rpa/docs/selenium-ide#throwerror");
                if (s.Equals("onerror")) return Redirect("https://ui.vision/rpa/docs/selenium-ide#onerror");
                if (s.Equals("sourcesearch")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/sourceextract-sourcesearch");
                if (s.Equals("sourceextract")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/sourceextract-sourcesearch");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!! 

                if (s.Equals("bringbrowsertoforeground")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/bringbrowsertoforeground");
                if (s.Equals("bringideandbrowsertobackground")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/bringbrowsertoforeground#tobackground");
                if (s.Equals("comment")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/comment");
                if (s.Equals("waitforvisible")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/waitforvisible");
                if (s.Equals("waitforelementvisible")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/waitforelementvisible");
                if (s.Equals("waitforelementnotvisible")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/waitforelementvisible");

                if (s.Equals("waitforelementpresent")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/waitforelementpresent");
                if (s.Equals("waitforelementnotpresent")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/waitforelementpresent");

                if (s.Equals("do")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/do-repeatif");
                if (s.Equals("repeatif")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/do-repeatif");
                if (s.Equals("addselection")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/addselection-removeselection");
                if (s.Equals("removeselection")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/addselection-removeselection");

                if (s.Equals("break")) return Redirect("https://ui.vision/rpa/docs/selenium-ide#break");
                if (s.Equals("continue")) return Redirect("https://ui.vision/rpa/docs/selenium-ide#continue");

                //V5.5.3
                if (s.Equals("times")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/times");
                if (s.Equals("foreach")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/foreach");
                if (s.Equals("csvreadarray")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/csvread#array");
                if (s.Equals("csvsavearray")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/csvsave#array");
                if (s.Equals("executescriptasync")) return Redirect(url1 + "executescript#async");
                if (s.Equals("executescriptasync_sandbox")) return Redirect(url1 + "executescript#async_sb");


                //nicht mehr hier!! nun bei GOTO.ui.Vision!!!

                if (s.Equals("editcontent")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/editcontent");
                if (s.Equals("localstorageexport")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/localstorageexport");
                if (s.Equals("storeimage")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/storeimage");
                if (s.Equals("saveitem")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/saveitem");
                //if (s.Equals("visionfind")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/visionfind");//outdated


                if (s.Equals("resize")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/resize");
                if (s.Equals("run")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/run");

                if (s.Equals("visualassert")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visualassert");
                if (s.Equals("visualsearch")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visualassert");
                if (s.Equals("visualverify")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visualassert");

                if (s.Equals("prompt")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/#prompt");

                if (s.Equals("visionlimitsearcharea")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visionlimitsearcharea");
                if (s.Equals("visionlimitsearcharearelative")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visionlimitsearcharearelative");

                if (s.Equals("ocrextract")) return Redirect("https://forum.ocr.space/t/ocrextract-error-cannot-read-properties-of-null-or-visualassert-no-input-image-found-for-file-name/15089/4");
                if (s.Equals("ocrextractscreenshot")) return Redirect("https://forum.ocr.space/t/ocrextract-error-cannot-read-properties-of-null-or-visualassert-no-input-image-found-for-file-name/15089/4");
                if (s.Equals("ocrextractrelative")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrextractrelative");
                if (s.Equals("ocrsearch")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrsearch");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!!

                if (s.Equals("xdesktopautomation")) return Redirect("https://ui.vision/rpa/x/desktop-automation#xdesktopautomation");
                if (s.Equals("xmousewheel")) return Redirect("https://ui.vision/rpa/docs/xclick#xmousewheel");
                if (s.Equals("capturedesktopscreenshot")) return Redirect("https://ui.vision/rpa/x/desktop-automation#capturedesktopscreenshot");

                if (s.Equals("xrun")) return Redirect("https://ui.vision/rpa/docs/xrun");
                if (s.Equals("xrunandwait")) return Redirect("https://ui.vision/rpa/docs/xrun#xrunandwait");

                if (s.Equals("visualgetpixelcolor")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visualgetpixelcolor");

                if (s.Equals("visionlimitsearchareabytextrelative")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visionlimitsearchareabytextrelative");

                if (s.Equals("aiprompt")) return Redirect("https://ui.vision/ai/prompt");
                if (s.Equals("aiscreenxy")) return Redirect("https://ui.vision/ai/screenxy");
                if (s.Equals("aicomputeruse")) return Redirect("https://ui.vision/ai/computeruse");
            };//s check

            //new shelp

            if (shelp != null)
            { 
                if (shelp.Equals("timeout_macro")) return Redirect("https://ui.vision/rpa/docs#!timeout_macro");
                if (shelp.Equals("timeout_pageload")) return Redirect("https://ui.vision/rpa/docs#!timeout_pageload");
                if (shelp.Equals("timeout_wait")) return Redirect("https://ui.vision/rpa/docs#!timeout_wait");
                if (shelp.Equals("timeout_download")) return Redirect("https://ui.vision/rpa/docs#!timeout_download");

                if (shelp.Equals("command_interval")) return Redirect("https://ui.vision/rpa/docs#!replayspeed");
                if (shelp.Equals("cmdline")) return Redirect("https://ui.vision/rpa/docs#cmd");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!!

                if (shelp.Equals("old_style_test_cases")) return Redirect("https://ui.vision/rpa/docs#testsuites_old");
                if (shelp.Equals("website_whitelist")) return Redirect("https://ui.vision/rpa/docs#embed");

                if (shelp.Equals("encryption")) return Redirect("https://ui.vision/rpa/docs#encryption");
                if (shelp.Equals("internalvars")) return Redirect("https://ui.vision/rpa/docs#internalvar"); //no S behind var!

                if (shelp.Equals("forum")) return Redirect("https://forum.ocr.space");
                if (shelp.Equals("github")) return Redirect("https://github.com/A9T9/RPA");
                if (shelp.Equals("docs")) return Redirect("https://ui.vision/rpa/docs");
                if (shelp.Equals("visual")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing");

                if (shelp.Equals("storage_mode")) return Redirect("https://ui.vision/rpa/x#storage_mode");
                if (shelp.Equals("xfileaccess")) return Redirect("https://ui.vision/rpa/x/#storage_mode");
                if (shelp.Equals("xfileaccess_download")) return Redirect("https://ui.vision/rpa/x/download");
                if (shelp.Contains("xfileaccess_updatecheck")) return Redirect("https://ui.vision/rpa/x/download");

                if (shelp.Equals("xmodule-ocr")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#xmodule-ocr");
                if (shelp.Equals("xmodule-ocr_download")) return Redirect("https://ui.vision/rpa/x/download");
                if (shelp.Contains("xmodule-ocr_updatecheck")) return Redirect("https://ui.vision/rpa/x/download");
                //contains      if (shelp.Equals("xfileaccess_updatecheck?xversion=1.0.6")) return Redirect("https://ui.vision/rpa/x/download");

                if (shelp.Equals("xclick")) return Redirect("https://ui.vision/rpa/x/");
                if (shelp.Equals("xclick_download")) return Redirect("https://ui.vision/rpa/x/download");
                if (shelp.Contains("xclick_updatecheck")) return Redirect("https://ui.vision/rpa/x/download");
                if (shelp.Contains("xscreencapture_updatecheck")) return Redirect("https://ui.vision/rpa/x/download");
                if (shelp.Contains("xscreencapture_download")) return Redirect("https://ui.vision/rpa/x/download");

                if (shelp.Equals("relative_clicks")) return Redirect("https://ui.vision/rpa/docs/xclick#relative");

                if (shelp.Equals("firefox_access_data_permission")) return Redirect("https://ui.vision/rpa/docs/firefox#permission");

                if (shelp.Equals("ocr")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocr");
                if (shelp.Equals("ocronline")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocronline");
                if (shelp.Equals("ocradd")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocradd");
                if (shelp.Equals("ocroffline")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocroffline");
                if (shelp.Equals("ocrlanguage")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrlanguage");
                if (shelp.Equals("ocrengine")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrengine");

                if (shelp.Equals("ocronline")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocronline");
                if (shelp.Equals("ocrenterprise")) return Redirect("https://ui.vision/rpa/x/desktop-automation/screen-scraping#ocrenterprise");

                if (shelp.Equals("ocr-calibrate-textrelative")) return Redirect("https://ui.vision/rpa/docs/xclick#ocr-calibrate-textrelative");
                if (shelp.Equals("ocrdesktopscaling")) return Redirect("https://ui.vision/rpa/docs/xclick#ocrdesktopscaling");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!!

                if (shelp.Equals("xscreencapture")) return Redirect("https://ui.vision/rpa/x/desktop-automation/#howto");

                if (shelp.Equals("k_welcome")) return Redirect("https://ui.vision/rpa/home/welcome?t=hello");
                if (shelp.Equals("k_update")) return Redirect("https://ui.vision/rpa/home/whatsnew");
                if (shelp.Equals("k_why")) return Redirect("https://ui.vision/rpa/home/uninstallsurvey");

                if (shelp.Equals("k_xupgrade")) return Redirect("https://ui.vision/rpa/x/pricing/#upgrade");
                if (shelp.Equals("k_xupgradepro")) return Redirect("https://ui.vision/rpa/x/pricing/#upgradepro");

                if (shelp.Equals("xdesktop")) return Redirect("https://ui.vision/rpa/x/desktop-automation#xdesktopautomation");
                if (shelp.Equals("xdesktop_download")) return Redirect("https://ui.vision/rpa/x/download");
                if (shelp.Contains("xdesktop_updatecheck")) return Redirect("https://ui.vision/rpa/x/download");//contains! wg version number hintendran!

                if (shelp.Equals("limitsearcharea")) return Redirect("https://ui.vision/rpa/docs/visual-ui-testing#visionlimitsearcharea");

                if (shelp.Equals("sidepanel")) return Redirect("https://ui.vision/rpa/docs/sidepanel");
                if (shelp.Equals("sidepanel_left")) return Redirect("https://ui.vision/rpa/docs/sidepanel#left");

                //nicht mehr hier!! nun bei GOTO.ui.Vision!!!
                if (shelp.Equals("ocr-local")) return Redirect("https://ui.vision/rpa/docs/ocr#ocr-local");
                if (shelp.Equals("ocr-request")) return Redirect("https://ui.vision/rpa/docs/ocr#ocr-request");
                if (shelp.Equals("free-ocr-api")) return Redirect("https://ui.vision/rpa/docs/ocr#free-ocr-api");

                if (shelp.Equals("folder_as_testsuites")) return Redirect("https://ui.vision/rpa/docs#testsuites");
                if (shelp.Equals("import_side")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/#import_side");
                if (shelp.Equals("import_html")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/#import_html");
                if (shelp.Equals("bkup_import")) return Redirect("https://ui.vision/rpa/docs#bkup_import");
                if (shelp.Equals("alternative_locators")) return Redirect("https://ui.vision/rpa/docs/selenium-ide/locators#recording");

                if (shelp.Equals("error101")) return Redirect("https://forum.ocr.space/t/error-101-solution/7440");
                if (shelp.Equals("error120")) return Redirect("https://forum.ocr.space/t/xclick-error-visualassert-no-input-image-found-for-file-name/7567/2");
                if (shelp.Equals("error121")) return Redirect("https://forum.ocr.space/t/xclick-error-visualassert-no-input-image-found-for-file-name/7567/2");

                if (shelp.Equals("darkmode")) return Redirect("https://forum.ocr.space/t/night-mode-dark-mode/9064/11");

                if (shelp.Equals("ai")) return Redirect("https://ui.vision/ai");

            };//shelp

            //nothing found? show main doc page
            return Redirect(url1);

            return View();
        }

        [Route("~/x/seeshell-help")]
        public ActionResult x_seehelp()
        {

            //http://localhost:3437/x/seeshell-help?cmd=click
            var s = "";
            s = Request.QueryString["cmd"];
            
            var shelp = "";
            shelp = Request.QueryString["help"];

            var url1 = "https://ui.vision/seeshell/docs/#";

            string logpath = ConfigurationManager.AppSettings["logfilelocationseeshellhelp"];

            string ip = Request.UserHostAddress;
            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {   //NUR HIER; 
                w.Write("\r\n{0},{1},{2},{3},", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ip, s);
            }

            if (s != null)
            {
                s = s.ToLower();
                if (s.Contains("clickat")) return Redirect(url1 + s);
                if (s.Equals("if")) return Redirect(url1 + "if"); //contains => auch für endif und verifytext matches
                if (s.Contains("else")) return Redirect(url1 + "if");
                return Redirect(url1+s);
            };//s check

            //new shelp - NICHT benutzt zur zeit... für allgemeine links in der app
            if (shelp != null)
            {
                if (shelp.Equals("timeout_macro")) return Redirect("https://ui.vision/rpa/docs#!timeout_macro");
               
            };//shelp

            //nothing found? show main doc page
            return Redirect(url1);

            return View();
        }



        [Route("~/rd/colorfish")]
        public ActionResult rd_colorfish()
        {

            //http://localhost:3437/rd/copyfish?help=t1
            //  var s = "";
            //  s = Request.QueryString["cmd"];

            var shelp = "";
            shelp = Request.QueryString["help"];

            string logpath = ConfigurationManager.AppSettings["logfile-colorfish1"];

            /*     string ip = Request.UserHostAddress;
                 using (StreamWriter w = System.IO.File.AppendText(logpath))
                 {   //NUR HIER; 
                     w.Write("\r\n{0},{1},{2},{3},", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ip, s);
                 }
             */

            //new shelp - NICHT benutzt zur zeit... für allgemeine links in der app
            if (shelp != null)
            {
                shelp = shelp.ToLower();
       
                if (shelp.Equals("desktop")) return Redirect("https://ui.vision/colorfish#desktop");
                if (shelp.Equals("download")) return Redirect("https://ui.vision/x/download");
        
                if (shelp.Equals("fileurl")) return Redirect("https://ui.vision/colorfish/docs#fileurl");
            };//shelp

            //nothing found? show main doc page
            return Redirect("https://ui.vision/colorfish/");

            return View();
        }


    }
    }
