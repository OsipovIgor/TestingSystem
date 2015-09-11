using System.Web.Mvc;
using System.Web.Security;

namespace TestingSystem.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Authorization");
        }

    }
}
