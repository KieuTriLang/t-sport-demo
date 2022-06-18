using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TSport.Services.ProductService;

namespace TShop.Controllers
{
    [Route("shop")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int page = 1)
        {

            var products = _productService.GetAll();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = 12;
            //ViewBag.PageCount = products.Count() % 12 > 0 ? (products.Count() / 12) + 1 : products.Count() / 12;
            ViewBag.ListItem = products.Skip((page - 1) * 12).Take(12);
            return View();
        }
    }
}
