using Microsoft.AspNetCore.Mvc;

namespace TShop.Controllers
{
    [Route("shop")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
