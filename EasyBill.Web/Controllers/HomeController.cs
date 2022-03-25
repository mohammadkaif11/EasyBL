using EasyBill.Buisness;
using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EasyBill.Web.Controllers
{
    public class HomeController : Controller
    {

        private IUserService _UserService = null;

        public HomeController(IUserService userService)
        {
            _UserService=userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //User Login Here
        [HttpPost]
        public ActionResult Login(string UserEmail ,string UserPassword,string ConfirmPassword)
        {
            if (UserPassword != ConfirmPassword)
            {
                return View();
            }
            else
            {
                User user = _UserService.Login(UserEmail, UserPassword);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(UserEmail, false);
                    Session["user"] = user;
                   return  RedirectToAction("Index", "Bill");
                }
            }

            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

        //User Register Here 
        [HttpPost]
        public ActionResult Register(User obj,string  ConfirmPassword)
        {
            if (obj.UserPassword != ConfirmPassword)
            {
                return View();
            }
 
                obj.UserJoinDate = DateTime.Now;
                obj.UserBillSno = 1;
                int a = _UserService.Register(obj);
                if (a > 0)
                {
                  return   RedirectToAction("Login");
                }
             
                    return View();
              
            
        }

         [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }
             
    }
}