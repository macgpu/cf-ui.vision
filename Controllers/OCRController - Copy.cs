
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

namespace xxxxxxxOCRReaderMVCWeb.Controllers
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

        //   [Route("~/kantu/welcome")]
        //     [Route("~/seeshell/web-automation/firefox/welcome")]
        [Route("~/kantu/home/welcome")]
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

        [Route("~/uivision")]
        public ActionResult uivision() { return View(); }

        [Route("~/uivision/desktop")]
        public ActionResult uivision_desktopautomation() { return View(); }

        [Route("~/kantu/desktop")]
        public ActionResult kantu_desktopautomation() { return View(); }

        //   [Route("~/kantu/whatsnew")]
        [Route("~/kantu/home/whatsnew")]
        public ActionResult kantu_home_whatsnew() { return View();}

 //       [Route("~/kantu/archive")]
        [Route("~/kantu/archive")]
        public ActionResult kantu_archive() { return View(); }



 //       [Route("~/kantu/why")]
        [Route("~/kantu/home/uninstallsurvey")]
        public ActionResult kantu_home_uninstallsurvey()
        {
            return View();
        }

        [Route("~/kantu/home/x/uninstallsurvey")]
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
        //    [Route("~/kantu/web-scraping")] //wg. SEO diese nicht benützt, erst später wieder, wenn es auch /screen-scraping gibt?
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

//        [Route("~/kantu/desktop-automation")]
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

        //[Route("~/seeshell/api")]
        [Route("~/seeshell/api")]
        public ActionResult seeshell_api()
        {
            return View();
        }

        //    [Route("~/kantu/")]
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


 //       [Route("~/kantu/eula")]
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


        [Route("~/kantu/demo/")]
        public ActionResult kantu_demo()
        {
            return View();
        }

        [Route("~/kantu/demo/cleanup")]
        public ActionResult kantu_demo_cleanup() {return View(); }


        [Route("~/kantu/demo/table")]
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

        [Route("~/kantu/demo/csvSave")] public ActionResult kantu_demo_csvSave() {return View();   }

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
        [Route("~/kantu/demo/pageloadtimeout")]
        public ActionResult kantu_demo_pageloadtimeout()
        {
            return View();
        }

        [Route("~/kantu/demo/tabs/1")]
        public ActionResult kantu_demo_tabs_1()
        {
            return View();
        }

        [Route("~/kantu/demo/tabs/2")]
        public ActionResult kantu_demo_tabs_2()
        {
            return View();
        }

        [Route("~/kantu/demo/tabs")]
        public ActionResult kantu_demo_tabs()
        {
            return View();
        }


        [Route("~/kantu/demo/draw")]
        public ActionResult kantu_demo_draw()
        {
            return View();
        }

        [Route("~/kantu/demo/xtype")]
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


        [Route("~/kantu/demo/storeeval")]
        public ActionResult kantu_demo_storeeval()
        {
            return View();
        }

        [Route("~/kantu/demo/executescript")]
        public ActionResult kantu_demo_executescript()
        {
            return View();
        }


        [Route("~/kantu/demo/waitforvisible")]
        public ActionResult kantu_demo_waitforvisible()
        {
            return View();
        }


        [Route("~/kantu/demo/filedownload")]
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


        [Route("~/kantu/demo/runweb")]
        public ActionResult kantu_demo_runweb()
        {
            return View();
        }

        [Route("~/kantu/demo/runhtml")]
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


        [Route("~/kantu/demo/iframes")]
        public ActionResult kantu_demo_iframes()
        {
            return View();
        }

        [Route("~/kantu/demo/canvas")]
        public ActionResult kantu_demo_canvas()
        {
            return View();
        }


        [Route("~/store")]
        public ActionResult store()
        {
            return View();
        }

        [Route("~/kantu/x")]
        public ActionResult kantu_x(){return View();}

        [Route("~/kantu/x/desktop-automation")]
        public ActionResult kantu_x_desktopautomation() { return View(); }

        [Route("~/kantu/x/desktop-automation/screen-scraping")]
        public ActionResult kantu_x_da_screenscraping() { return View(); }

        [Route("~/kantu/x/rpa")] //use it?
        public ActionResult kantu_x_rpa() { return View(); }

        [Route("~/kantu/x/customers")] //use it?
        public ActionResult kantu_x_customers() { return View(); }

        [Route("~/kantu/x/pro")]
        public ActionResult kantu_x_pro() { return View(); }

        [Route("~/kantu/x/pricing")]
        public ActionResult kantu_x_pricing() { return View(); }

        [Route("~/kantu/x/download")]
        public ActionResult kantu_x_download() {return View();}

        [Route("~/kantu/home/x")]
        public ActionResult kantu_home_x() {return View();}

        [Route("~/kantu/docs/xclick")]
        public ActionResult kantu_docs_xclick() {return View();}

        [Route("~/docs/xclick")]
        public ActionResult k_docs_xclick() { return View(); }

        //[Route("~/kantu/docs/x/xmove")]
        //public ActionResult kantu_docs_x_xmove() { return View(); }


        [Route("~/kantu/docs/xtype")]
        public ActionResult kantu_docs_xtype() { return View(); }


        [Route("~/seeshell/docs")]
        public ActionResult seeshell_docs()
        {
            return View();
        }

        //TMP BIS ALLES RENAMED
        /*
        [Route("~/docs")]
        public ActionResult kantu_docsTMP()
        {
            return View();
        }*/

        [Route("~/seeshell/flash")]
        public ActionResult seeshell_flash()
        {
            return View();
        }

        [Route("~/kantu/flash")]
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
        [Route("~/sikuli/eggplant")]
        public ActionResult sikuli_eggplant()
        {
            return View();
        }
        [Route("~/sikuli/pyautogui")]
        public ActionResult sikuli_pyautogui()
        {
            return View();
        }
        [Route("~/sikuli/winium")]
        public ActionResult sikuli_winium()
        {
            return View();
        }
        [Route("~/sikuli/qtp")]
        public ActionResult sikuli_qtp()
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





        [Route("~/copyfish/welcome")] 
        public ActionResult copyfish_welcome()  {  return View(); }

        [Route("~/copyfish/whatsnew")]
        public ActionResult copyfish_whatsnew() { return View(); }

        [Route("~/copyfish/why")]
        public ActionResult copyfish_why() { return View(); }

        [Route("~/copyfish/")]
        public ActionResult copyfish()
        {
            return View();
        }

        [Route("~/copyfish/docs")]
        public ActionResult copyfish_docs()
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
        [Route("~/kantu/docs/")]
          public ActionResult kantu_docs() { return View(); }


      
        [Route("~/kantu/docs/selenium-ide/")]
        public ActionResult kantu_docs_seleniumide()  { return View();  }

        [Route("~/kantu/docs/selenium-ide/web-scraping")]
        public ActionResult kantu_docs_seleniumide_webscraping() { return View(); }

        [Route("~/kantu/docs/selenium-ide/form-filling")]
        public ActionResult kantu_docs_seleniumide_formfilling() { return View(); }


        [Route("~/kantu/docs/selenium-ide/answerOnNextPrompt")]
        public ActionResult kantu_docs_seleniumide_answerOnNextPrompt() { return View(); }

        [Route("~/kantu/docs/selenium-ide/assertAlert-assertConfirmation-assertPrompt")]
        public ActionResult kantu_docs_seleniumide_assertAlertassertConfirmationassertPrompt() { return View(); }


        [Route("~/kantu/docs/selenium-ide/assertElementPresent-verifyElementPresent")]
        public ActionResult kantu_docs_seleniumide_assertElementPresentverifyElementPresent() { return View(); }


        [Route("~/kantu/docs/selenium-ide/assertText-verifytext")]
        public ActionResult kantu_docs_seleniumide_asserttextverifytext() { return View(); }


        [Route("~/kantu/docs/selenium-ide/assertTitle-verifyTitle")]
        public ActionResult kantu_docs_seleniumide_asserttitleverifytitle() { return View(); }

        [Route("~/kantu/docs/selenium-ide/assertvalue-verifyvalue")]
        public ActionResult kantu_docs_seleniumide_assertvalueverifyvalue() { return View(); }

        [Route("~/kantu/docs/selenium-ide/captureScreenshot")]
        public ActionResult kantu_docs_seleniumide_captureScreenshot() { return View(); }

        [Route("~/kantu/docs/selenium-ide/click")]
        public ActionResult kantu_docs_seleniumide_click() { return View(); }

        [Route("~/kantu/docs/selenium-ide/bringbrowsertoforeground")]
        public ActionResult kantu_docs_seleniumide_bringbrowsertoforeground() { return View(); }

        [Route("~/kantu/docs/selenium-ide/comment")]
        public ActionResult kantu_docs_seleniumide_comment() { return View(); }


        [Route("~/kantu/docs/selenium-ide/resize")]
        public ActionResult kantu_docs_seleniumide_resize() { return View(); }

        [Route("~/kantu/docs/selenium-ide/run")]
        public ActionResult kantu_docs_seleniumide_run() { return View(); }

        [Route("~/kantu/docs/visual-ui-testing")]
        public ActionResult kantu_docs_visualuitesting() { return View(); }

        [Route("~/kantu/docs/selenium-ide/highlight")]
        public ActionResult kantu_docs_seleniumide_highlight() { return View(); }

        [Route("~/kantu/docs/selenium-ide/clickAt")]
        public ActionResult kantu_docs_seleniumide_clickAt() { return View(); }

        [Route("~/kantu/docs/selenium-ide/csvSave")]
        public ActionResult kantu_docs_seleniumide_csvSave() { return View(); }

        [Route("~/kantu/docs/selenium-ide/csvread")]
        public ActionResult kantu_docs_seleniumide_csvread() { return View(); }


        [Route("~/kantu/docs/selenium-ide/deleteAllVisibleCookies")]
        public ActionResult kantu_docs_seleniumide_deleteAllVisibleCookies() { return View(); }


        [Route("~/kantu/docs/selenium-ide/deleteAllCookies")]
        public ActionResult kantu_docs_seleniumide_deleteAllCookies() { return View(); }

        [Route("~/kantu/docs/selenium-ide/dragAndDropToObject")]
        public ActionResult kantu_docs_seleniumide_dragAndDropToObject() { return View(); }

        [Route("~/kantu/docs/selenium-ide/echo")]
        public ActionResult kantu_docs_seleniumide_echo() { return View(); }

        [Route("~/kantu/docs/selenium-ide/editcontent")]
        public ActionResult kantu_docs_seleniumide_editcontent() { return View(); }

        [Route("~/kantu/docs/selenium-ide/executescript")]
        public ActionResult kantu_docs_seleniumide_executescript() { return View(); }

        [Route("~/kantu/docs/selenium-ide/if")]
        public ActionResult kantu_docs_seleniumide_if() { return View(); }

        [Route("~/kantu/docs/selenium-ide/gotoif")]
        public ActionResult kantu_docs_seleniumide_gotoif() { return View(); }

        [Route("~/kantu/docs/selenium-ide/gotolabel")]
        public ActionResult kantu_docs_seleniumide_gotolabel() { return View(); }

        [Route("~/kantu/docs/selenium-ide/label")]
        public ActionResult kantu_docs_seleniumide_label() { return View(); }

        [Route("~/kantu/docs/selenium-ide/mouseOver")]
        public ActionResult kantu_docs_seleniumide_mouseOver() { return View(); }

        [Route("~/kantu/docs/selenium-ide/open")]
        public ActionResult kantu_docs_seleniumide_open() { return View(); }

        [Route("~/kantu/docs/selenium-ide/pause")]
        public ActionResult kantu_docs_seleniumide_pause() { return View(); }

        [Route("~/kantu/docs/selenium-ide/localstorageexport")]
        public ActionResult kantu_docs_seleniumide_localstorageexport() { return View(); }



        [Route("~/kantu/docs/selenium-ide/refresh")]
        public ActionResult kantu_docs_seleniumide_refresh() { return View(); }


        [Route("~/kantu/docs/selenium-ide/select")]
        public ActionResult kantu_docs_seleniumide_select() { return View(); }

        [Route("~/kantu/docs/selenium-ide/selectFrame")]
        public ActionResult kantu_docs_seleniumide_selectFrame() { return View(); }

        [Route("~/kantu/docs/selenium-ide/selectWindow")]
        public ActionResult kantu_docs_seleniumide_selectWindow() { return View(); }

        [Route("~/kantu/docs/selenium-ide/sendKeys-type")]
        public ActionResult kantu_docs_seleniumide_sendKeystype() { return View(); }


        [Route("~/kantu/docs/selenium-ide/sourceExtract-sourceSearch")]
        public ActionResult kantu_docs_seleniumide_sourceExtractsourceSearch() { return View(); }


        [Route("~/kantu/docs/selenium-ide/store")]
        public ActionResult kantu_docs_seleniumide_store() { return View(); }

        [Route("~/kantu/docs/selenium-ide/storedVars")]
        public ActionResult kantu_docs_seleniumide_storedVars() { return View(); }

        [Route("~/kantu/docs/selenium-ide/storeattribute")]
        public ActionResult kantu_docs_seleniumide_storeattribute() { return View(); }

        [Route("~/kantu/docs/selenium-ide/storeEval")]
        public ActionResult kantu_docs_seleniumide_storeEval() { return View(); }

   

        [Route("~/kantu/docs/selenium-ide/storeimage")]
        public ActionResult kantu_docs_seleniumide_storeimage() { return View(); }

        [Route("~/kantu/docs/selenium-ide/storeText")]
        public ActionResult kantu_docs_seleniumide_storeText() { return View(); }

        [Route("~/kantu/docs/selenium-ide/storeTitle")]
        public ActionResult kantu_docs_seleniumide_storeTitle() { return View(); }


        [Route("~/kantu/docs/selenium-ide/storeValue")]
        public ActionResult kantu_docs_seleniumide_storevalue() { return View(); }

        [Route("~/kantu/docs/selenium-ide/storechecked")] public ActionResult kantu_docs_seleniumide_storechecked() { return View(); }
        [Route("~/kantu/docs/selenium-ide/assertchecked-verifychecked")] public ActionResult kantu_docs_seleniumide_assertcheckedverifychecked() { return View(); }


        [Route("~/kantu/docs/selenium-ide/WaitForElementPresent")]
        public ActionResult kantu_docs_seleniumide_WaitForElementPresent() { return View(); }

        [Route("~/kantu/docs/selenium-ide/WaitForVisible")]
        public ActionResult kantu_docs_seleniumide_WaitForVisible() { return View(); }

        [Route("~/kantu/docs/selenium-ide/waitForPageToLoad")]
        public ActionResult kantu_docs_seleniumide_waitForPageToLoad() { return View(); }


        [Route("~/kantu/docs/selenium-ide/while")]
        public ActionResult kantu_docs_seleniumide_while() { return View(); }

        [Route("~/kantu/docs/selenium-ide/end")]
        public ActionResult kantu_docs_seleniumide_end() { return View(); }

        [Route("~/kantu/docs/selenium-ide/oldfirefoxide")]
        public ActionResult kantu_docs_seleniumide_oldfirefoxide() { return View(); }


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

            //TEST:  https://a9t9.com/x/k?v=2.0.1.0B111CXX
            //                                                                               "2.0.5.0B111CXX"; //free version, api not used, non-adwords
            //http://localhost:3437/x/k?kantu=Hello&m1=GettingStarted&m2=CheckingForUpdates&v=2.2.3.0B190RBX
            var s = "";
            s = Request.QueryString["v"];

            var homeurl = "https://a9t9.com/";

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
            var url = "https://a9t9.com/seeshell/browser/home/kantux";

            if (IsPro) url = "http://a9t9.com/seeshell/browser/home/kantuxpro";
            if (IsProTrial) url = "http://a9t9.com/seeshell/browser/home/kantux";

            if (UpgradeAvail) url = url + "?info=updateavailable";


            return Redirect(url);
            //         System.IO.File.AppendAllText(@"c:\path\file.txt", "text content" + Environment.NewLine);



            return View();
        }

        //seeshell!
        [Route("~/x/s")] //TODO: new redir for seeshell and ss browser
        public ActionResult x_s()
        {

            //TEST:  https://a9t9.com/x/s?v=2.0.1.0B111CXX
            //                                                                               "2.0.5.0B111CXX"; //free version, api not used, non-adwords
            //2 b?? => errror                     http://localhost:3437/x/s?seeshell=desktop&kantu=Hello&m1=GettingStarted&m2=CheckingForUpdates&v=2.2.3.0B190RBX

            // http://localhost:3437/x/s?seeshell=desktop&m1=GettingStarted&m2=CheckingForUpdates&v=2.2.3.0B190RXX
            // https://a9t9.com/x/s?SeeShell=Browser&m1=GettingStarted&m2=CheckingForUpdates&v=3.1.0.0B111RXX
            var s = "";
            s = Request.QueryString["v"];
            var sdeskorweb = Request.QueryString["seeshell"];
            var homeurl = "https://a9t9.com/";
            
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
                 url = "https://a9t9.com/seeshell/home";
                if (IsPro) url = "http://a9t9.com/seeshell/home/pro";
                if (UpgradeAvail) url = url + "?info=updateavailable";
            }
            else
            {
                 url = "https://a9t9.com/seeshell/browser/home";
                if (IsPro) url = "http://a9t9.com/seeshell/browser/home/pro";
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

            //TEST:  https://a9t9.com/x/idehelp?cmd=capturescreenshot
            //TEST:  https://a9t9.com/x/idehelp?cmd=asserttext
            //TEST:  https://a9t9.com/x/idehelp?cmd=type
            //TEST:  https://a9t9.com/x/idehelp?cmd=NOTFOUNDxxx

            //TEST:  https://a9t9.com/x/idehelp?help=timeout_macro


            //http://localhost:3437/x/idehelp?cmd=capturescreenshot
            var s = "";
            s = Request.QueryString["cmd"];

            var shelp = "";
            shelp = Request.QueryString["help"];

            var url1 = "https://a9t9.com/kantu/docs/selenium-ide/";
            var urldocs = "https://a9t9.com/kantu/docs/";//unused?!

            string logpath = ConfigurationManager.AppSettings["logfilelocationidehelp"];

            string ip = Request.UserHostAddress;
            using (StreamWriter w = System.IO.File.AppendText(logpath))
            {   //NUR HIER; 
                w.Write("\r\n{0},{1},{2},{3},", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ip, s);
            }

            if (s != null)
            {

                //diese vor click contains
                if (s.Equals("xclick")) return Redirect("https://a9t9.com/kantu/docs/xclick");
                if (s.Equals("xmove")) return Redirect("https://a9t9.com/kantu/docs/xclick");
                if (s.Equals("xtype")) return Redirect("https://a9t9.com/kantu/docs/xtype");

                if (s.Equals("xclickrelative")) return Redirect("https://a9t9.com/kantu/docs/xclick#relative");
                if (s.Equals("xmoverelative")) return Redirect("https://a9t9.com/kantu/docs/xclick#relative");

                if (s.Contains("clickat")) return Redirect(url1 + s);
                if (s.Contains("csvread")) return Redirect(url1 + s);
                if (s.Contains("csvsave")) return Redirect(url1 + s);
                if (s.Contains("deleteallcookies")) return Redirect(url1 + s);
                if (s.Contains("answeronnextprompt")) return Redirect(url1 + s);
                if (s.Contains("draganddroptoobject")) return Redirect(url1 + s);
                if (s.Contains("echo")) return Redirect(url1 + s);
                if (s.Contains("gotoif")) return Redirect(url1 + s);
                if (s.Contains("gotolabel")) return Redirect(url1 + s);
                if (s.Contains("label")) return Redirect(url1 + s);
                if (s.Contains("open")) return Redirect(url1 + s);
                if (s.Contains("mouseover")) return Redirect(url1 + s);
                if (s.Contains("pause")) return Redirect(url1 + s);
                if (s.Contains("refresh")) return Redirect(url1 + s);
                if (s.Contains("storeeval")) return Redirect(url1 + s);
                if (s.Contains("selectframe")) return Redirect(url1 + s);
                if (s.Contains("selectwindow")) return Redirect(url1 + s);
                if (s.Contains("store")) return Redirect(url1 + s);
                if (s.Contains("storetext")) return Redirect(url1 + s);
                if (s.Contains("storetitle")) return Redirect(url1 + s);
                if (s.Contains("storevalue")) return Redirect(url1 + s);
                if (s.Contains("storechecked")) return Redirect(url1 + s);
                if (s.Contains("waitforpagetoload")) return Redirect(url1 + s);
                if (s.Contains("capturescreenshot")) return Redirect(url1 + s);

                if (s.Contains("capturescreenshot")) return Redirect(url1 + s);
                if (s.Contains("captureentirepagescreenshot")) return Redirect(url1 + "capturescreenshot");

                if (s.Equals("while")) return Redirect(url1 + s);
                if (s.Equals("end")) return Redirect(url1 + "end");
                if (s.Equals("endif")) return Redirect(url1 + "end");
                if (s.Equals("endwhile")) return Redirect(url1 + "end");

                if (s.Equals("if")) return Redirect(url1 + "if"); //contains => auch für endif und verifytext matches
                if (s.Contains("else")) return Redirect(url1 + "if");
                if (s.Contains("endif")) return Redirect(url1 + "if");

                if (s.Contains("assertchecked")) return Redirect(url1 + "assertchecked-verifychecked");
                if (s.Contains("verifychecked")) return Redirect(url1 + "assertchecked-verifychecked");

                if (s.Contains("assertelementpresent")) return Redirect(url1 + "assertelementpresent-verifyelementpresent");
                if (s.Contains("verifyelementpresent")) return Redirect(url1 + "assertelementpresent-verifyelementpresent");

                if (s.Contains("asserttext")) return Redirect(url1 + "asserttext-verifytext");
                if (s.Contains("verifytext")) return Redirect(url1 + "asserttext-verifytext");

                if (s.Contains("assertvalue")) return Redirect(url1 + "assertvalue-verifyvalue");
                if (s.Contains("verifyvalue")) return Redirect(url1 + "assertvalue-verifyvalue");

                if (s.Contains("verifytext")) return Redirect(url1 + "asserttext-verifytext");

                if (s.Contains("asserttitle")) return Redirect(url1 + "asserttitle-verifytitle");
                if (s.Contains("verifytitle")) return Redirect(url1 + "asserttitle-verifytitle");

                if (s.Contains("assertalert")) return Redirect(url1 + "assertalert-assertconfirmation-assertprompt");
                if (s.Contains("assertconfirmation")) return Redirect(url1 + "assertalert-assertconfirmation-assertprompt");
                if (s.Contains("assertprompt")) return Redirect(url1 + "assertalert-assertconfirmation-assertprompt");

                if (s.Contains("click")) return Redirect(url1 + "click");
                if (s.Contains("clickAndWait")) return Redirect(url1 + "click");

                if (s.Contains("select")) return Redirect(url1 + "select");
                if (s.Contains("selectAndWait")) return Redirect(url1 + "select");

                if (s.Contains("sendkeys")) return Redirect(url1 + "sendkeys-type");
                if (s.Contains("type")) return Redirect(url1 + "sendkeys-type");

                if (s.Contains("ondownload")) return Redirect("https://a9t9.com/kantu/docs#ondownload");
                if (s.Contains("throwerror")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide#throwerror");
                if (s.Contains("onerror")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide#onerror");
                if (s.Contains("sourcesearch")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/sourceextract-sourcesearch");
                if (s.Contains("sourceextract")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/sourceextract-sourcesearch");

                if (s.Contains("bringbrowsertoforeground")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/bringbrowsertoforeground");
                if (s.Contains("comment")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/comment");
                if (s.Contains("waitforvisible")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/waitforvisible");

                if (s.Contains("editcontent")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/editcontent");
                if (s.Contains("localstorageexport")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/localstorageexport");
                if (s.Contains("storeimage")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/storeimage");
                //if (s.Contains("visionfind")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/visionfind");//outdated


                if (s.Contains("resize")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/resize");
                if (s.Contains("run")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/run");

                if (s.Contains("visualassert")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing");
                if (s.Contains("visualsearch")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing");
                if (s.Contains("visualverify")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing");

                if (s.Contains("prompt")) return Redirect("https://a9t9.com/kantu/docs/selenium-ide/#prompt");

                if (s.Equals("visionlimitsearcharea")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing#visionlimitsearcharea");
                if (s.Equals("visionlimitsearcharearelative")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing#visionlimitsearcharearelative");

                if (s.Equals("ocrextract")) return Redirect("https://a9t9.com/kantu/docs#ocrextract");
                if (s.Equals("ocrextractrelative")) return Redirect("https://a9t9.com/kantu/docs#ocrextractrelative");

                if (s.Equals("xdesktopautomation")) return Redirect("https://a9t9.com/kantu/x/desktop-automation#xdesktopautomation");
                if (s.Equals("capturedesktopscreenshot")) return Redirect("https://a9t9.com/kantu/x/desktop-automation#capturedesktopscreenshot");

            };//s check

            //new shelp

            if (shelp != null)
            { 
                if (shelp.Equals("timeout_macro")) return Redirect("https://a9t9.com/kantu/docs#!timeout_macro");
                if (shelp.Equals("timeout_pageload")) return Redirect("https://a9t9.com/kantu/docs#!timeout_pageload");
                if (shelp.Equals("timeout_wait")) return Redirect("https://a9t9.com/kantu/docs#!timeout_wait");
                if (shelp.Equals("timeout_download")) return Redirect("https://a9t9.com/kantu/docs#!timeout_download");

                if (shelp.Equals("command_interval")) return Redirect("https://a9t9.com/kantu/docs#!replayspeed");

                if (shelp.Equals("website_whitelist")) return Redirect("https://a9t9.com/kantu/docs#embed");

                if (shelp.Equals("encryption")) return Redirect("https://a9t9.com/kantu/docs#encryption");
                if (shelp.Equals("internalvars")) return Redirect("https://a9t9.com/kantu/docs#internalvar"); //no S behind var!

                if (shelp.Equals("forum")) return Redirect("https://forum.a9t9.com");
                if (shelp.Equals("docs")) return Redirect("https://a9t9.com/kantu/docs");
                if (shelp.Equals("visual")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing");

                if (shelp.Equals("storage_mode")) return Redirect("https://a9t9.com/kantu/x#storage_mode");
                if (shelp.Equals("xfileaccess")) return Redirect("https://a9t9.com/kantu/x/");
                if (shelp.Equals("xfileaccess_download")) return Redirect("https://a9t9.com/kantu/x/download");
                if (shelp.Equals("xfileaccess_updatecheck")) return Redirect("https://a9t9.com/kantu/x/download");
                if (shelp.Equals("xfileaccess_updatecheck?xversion=1.0.6")) return Redirect("https://a9t9.com/kantu/x/download");

                if (shelp.Equals("xclick")) return Redirect("https://a9t9.com/kantu/x/");
                if (shelp.Equals("xclick_download")) return Redirect("https://a9t9.com/kantu/x/download");
                if (shelp.Equals("xclick_updatecheck")) return Redirect("https://a9t9.com/kantu/x/download");

                if (shelp.Equals("relative_clicks")) return Redirect("https://a9t9.com/kantu/docs/xclick#relative");

                if (shelp.Equals("ocr")) return Redirect("https://a9t9.com/kantu/x/desktop-automation/screen-scraping#ocr");
                if (shelp.Equals("ocronline")) return Redirect("https://a9t9.com/kantu/x/desktop-automation/screen-scraping#ocronline");
                if (shelp.Equals("ocradd")) return Redirect("https://a9t9.com/kantu/x/desktop-automation/screen-scraping#ocradd");
                if (shelp.Equals("ocroffline")) return Redirect("https://a9t9.com/kantu/x/desktop-automation/screen-scraping#ocroffline");
                if (shelp.Equals("ocrlanguage")) return Redirect("https://a9t9.com/kantu/x/desktop-automation/screen-scraping#ocrlanguage");


                if (shelp.Equals("k_welcome")) return Redirect("https://a9t9.com/kantu/home/welcome?t=hello");
                if (shelp.Equals("k_update")) return Redirect("https://a9t9.com/kantu/home/whatsnew");
                if (shelp.Equals("k_why")) return Redirect("https://a9t9.com/kantu/home/uninstallsurvey");

                if (shelp.Equals("k_xupgrade")) return Redirect("https://a9t9.com/kantu/x/pricing/#upgrade");
                if (shelp.Equals("k_xupgradepro")) return Redirect("https://a9t9.com/kantu/x/pricing/#upgradepro");

                if (shelp.Equals("xdesktop")) return Redirect("https://a9t9.com/kantu/x/desktop-automation#xdesktopautomation");
                if (shelp.Equals("xdesktop_download")) return Redirect("https://a9t9.com/kantu/x/download");

                if (shelp.Equals("limitsearcharea")) return Redirect("https://a9t9.com/kantu/docs/visual-ui-testing#visionlimitsearcharea");



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

            var url1 = "https://a9t9.com/seeshell/docs/#";

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
                if (shelp.Equals("timeout_macro")) return Redirect("https://a9t9.com/kantu/docs#!timeout_macro");
               
            };//shelp

            //nothing found? show main doc page
            return Redirect(url1);

            return View();
        }

    }
}
