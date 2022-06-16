using Microsoft.AspNetCore.Mvc;

namespace TShop.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
