using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using CustomerSupportLogger.Models;

namespace CustomerSupportLogger.Controllers
{
    public class HomeController : Controller
    {
        UserInfoMethods c1 = null;
        CustInfoLogMethods m1 = null;
        public HomeController()
        {
            c1 = new UserInfoMethods();
            m1 = new CustInfoLogMethods();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection c)
        {
            int u = Convert.ToInt32(c["UserId"]);
            string p = c["Password"].ToString();
            Userinfo t = c1.Checklogin(u, p);
            if(t!= null)
            {
                return RedirectToAction("AddComplaints");
            }
            else
            {
                ViewBag.Message1 = "Invalid Credentials..TryAgain";
                return View();
            }
        }
        public ActionResult AddComplaints()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddComplaints(FormCollection c)
        {
            CustLoginfo k = new CustLoginfo();
            Complaint k1 = new Complaint();
            k.Logid= Convert.ToInt32(c["LogId"]);
            k1.LogId = k.Logid;
            k.CustEmail = c["CustomerMail"].ToString();
            k1.CustomerMail = k.CustEmail;
            k.CustName = c["CustomerName"].ToString();
            k1.CustomerName = k.CustName;
            k.LogStatus = c["LogStatus"].ToString();
            k1.LogStatus = k.LogStatus;
            k.Description = c["Description"].ToString();
            k1.Description = k.Description;
            k.Userid = Convert.ToInt32(TempData["user"]);
            TempData["user"] = k.Userid;
            bool k2 = m1.SaveCustLog(k);
            if (k2 == true)
            {
                ViewBag.Message2 = "Saved Successfully";
                return View(k1);
            }
            else
            {
                ViewBag.Message3 = "Not Saved";
                return View();
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}