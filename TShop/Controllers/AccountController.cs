using Microsoft.AspNetCore.Mvc;

namespace TShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
