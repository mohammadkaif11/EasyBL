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
            return View();
        }
            [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Bills obj, IEnumerable<Items> obj2)
        {
            
            User user =(User)Session["user"];
            Invoice invoice = _BillService.Insert(user.ID,obj,obj2);
            if (invoice != null)
            {
                return View("Print",invoice);

            }
            ModelState.AddModelError("", "Please Fill The Chart");
            return View();
        }

        [HttpGet]
        public ActionResult Print()
        {
            return View();
        }
    }
}