using System.Web.Mvc;

namespace PostReaderWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "What is this site for?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For any questions please contact Vladimir Mackhnevich.";

            return View();
        }
    }
}