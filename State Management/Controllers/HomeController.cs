using State_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace State_Management.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(UserClass user)
        {
            if (Session["Name"] == null)
            {
                Session["Name"] = user.userName;
                Session["Email"] = user.email;
                Session["Password"] = user.pw;
                Session["Age"] = user.age;
            }
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.goodbye = $"Goodbye, {Session["Name"]}";
            Session["Name"] = null;

            return View();
        }
    }
}