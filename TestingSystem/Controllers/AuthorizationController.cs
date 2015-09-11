using System.Web.Mvc;
using System.Web.Security;
using TestingSystem.Models;

namespace TestingSystem.Controllers
{
    /// <summary>
    /// Контроллер авторизации
    /// </summary>
    [AllowAnonymous]
    public class AuthorizationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginInfo)
        {
            FormsAuthentication.SetAuthCookie(loginInfo.Login, true);
            return RedirectToAction("Index", "Main");
        }

    }
}
