using JobPotal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JobPotal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: About
        public ActionResult About()
        {
            return View();
        }  
        // GET: Contactus
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult AdminProfile()
        {
            return View();
        }


        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [Route("AdminLogin")]
        public ActionResult LogIn(Login data)
        {
            ViewBag.LoginStatus = "";
            if(data != null)
            {
                if(data.UserName == "Btps@gmail.com" && data.Password == "1234")
                {
                    FormsAuthentication.SetAuthCookie(data.UserName,data.RememberMe);
                    return RedirectToAction("Index","AdminPenal");
                }
                else
                {
                    ViewBag.LoginStatus = "Error ! Incorrect UserName and Password";
                }
            }
            return View();
        }

        [Route("logout")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        public ActionResult UserRegister()
        {
            return View();
        }
        [HttpPost]
        [Route("UserRegister")]
        public ActionResult UserRegister(UserRegister data)
        {

            return View();
        }
    }
}