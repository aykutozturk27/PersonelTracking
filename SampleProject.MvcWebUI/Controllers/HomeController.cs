using System.Web.Mvc;

namespace SampleProject.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}