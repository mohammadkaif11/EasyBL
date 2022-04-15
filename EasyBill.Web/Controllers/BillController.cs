using EasyBill.Buisness;
using EasyBill.Buisness.Model;
using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyBill.Web.Controllers
{
    [Authorize]
    public class BillController : Controller
    {
        private IBillService _BillService = null;

        public BillController(IBillService billService)
        {
            _BillService = billService; 
        }

 
        // GET: Bill    
        public ActionResult Index()
        {

            User user = (User)Session["user"];
            if (user != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        public ActionResult Create()
        {

            User user = (User)Session["user"];
            if (user != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
        }


        [HttpPost]
        public ActionResult Create(Bills obj, IEnumerable<Items> obj2)
        {
            
            User user =(User)Session["user"];
            if (user != null)
            {
                Invoice invoice = _BillService.Insert(user.ID, obj, obj2);
                if (invoice != null)
                {
                    return View("Print", invoice);

                }
                ModelState.AddModelError("", "Please Fill The Chart");
                return View();
            }
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        public ActionResult Print()
        {

            User user = (User)Session["user"];
            if (user != null)
            {
                return View();

            }
            return RedirectToAction("Login", "Home");

        }


        public ActionResult Get()
        {
            User user = (User)Session["user"];
            if (user!=null){
                var data = _BillService.Get(user.ID);
                return View(data);
            }
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Analaysis()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();

        }

    }
}