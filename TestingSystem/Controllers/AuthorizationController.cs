using System.Web.Mvc;
using System.Web.Security;
using TestingSystem.Models;

namespace TestingSystem.Controllers
{
    public class AuthorizationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginInfo)
        {
            FormsAuthentication.SetAuthCookie(loginInfo.Login, loginInfo.RememberMe);
            return RedirectToAction("Index", "Main");
        }

    }
}
