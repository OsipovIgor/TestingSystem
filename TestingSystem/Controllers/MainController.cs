using System.Web.Mvc;

namespace TestingSystem.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
