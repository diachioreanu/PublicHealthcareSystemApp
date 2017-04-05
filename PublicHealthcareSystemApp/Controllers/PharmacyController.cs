using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicHealthcareSystemApp.Controllers
{
    public class PharmacyController : Controller
    {
        // GET: Pharmacy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Stock()
        {
            return View();
        }
    }
}