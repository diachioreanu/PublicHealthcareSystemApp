using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult MedicalHistory()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult UserDetails()
        {
            ViewBag.Message = "Your details page.";

            return View();
        }
    }
}
