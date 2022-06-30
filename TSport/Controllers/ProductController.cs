using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TSport.Models;
using TSport.Services.BrandService;
using TSport.Services.CategoryService;
using TSport.Services.ColorService;
using TSport.Services.ProductService;
using TSport.Services.SizeService;

namespace TShop.Controllers
{
    [Route("shop")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IColorService _colorService;
        private readonly IBrandService _brandService;
        private readonly ISizeService _sizeService;
        private readonly IEnumerable<Product> _products;

        public ProductController(IProductService productService, ICategoryService categoryService,IColorService colorService,IBrandService brandService,ISizeService sizeService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _colorService = colorService;
            _brandService = brandService;
            _sizeService = sizeService;
            _products = _productService.GetAll();
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Categories = _categoryService.GetTopCategory();
            ViewBag.Colors = _colorService.GetAll();
            ViewBag.Sizes = _sizeService.GetTopSize();
            ViewBag.Brands = _brandService.GetAll();

            IEnumerable<Product> products = _products;
            int totalOfProduct = products.Count();
            ViewBag.TotalOfProduct = totalOfProduct;
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = totalOfProduct % 12 > 0 ? (totalOfProduct / 12) + 1 : totalOfProduct / 12;
            ViewBag.ListProduct = products.Skip((page - 1) * 12).Take(12);

            return View();
        }
        [HttpGet("filter")]
        public IActionResult FilterProduct(int page = 1, int? category = null, int? color = null, int? size = null, int? brand = null)
        {
            ViewBag.Categories = _categoryService.GetTopCategory();
            ViewBag.Colors = _colorService.GetAll();
            ViewBag.Sizes = _sizeService.GetTopSize();
            ViewBag.Brands = _brandService.GetAll();

            IEnumerable<Product> products = _products;
            if (category != null)
            {
                products = products.Where(x => x.CategoryId == category);
            }
            if (color != null)
            {
                products = products.Where(p => p.Colors.FirstOrDefault(c=>c.Id == color) != null).ToList();
            }
            if (size != null)
            {
                products = products.Where(p => p.Sizes.FirstOrDefault(s => s.Id == size) != null).ToList();
            }
            if (brand != null)
            {
                products = products.Where(x => x.BrandId == brand);
            }

            int totalOfProduct = products.Count();
            ViewBag.TotalOfProduct = totalOfProduct;
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = totalOfProduct % 12 > 0 ? (totalOfProduct / 12) + 1 : totalOfProduct / 12;
            ViewBag.ListProduct = products.Skip((page - 1) * 12).Take(12);

            return View("Index");
        }

        [Route("product/{id}")]
        public IActionResult ProductById(int id)
        {
            Product product = _productService.Get(id);
            ViewBag.RelateProducts = _products.Where(p=>p.BrandId == product.BrandId && p.Id != product.Id).ToList().Take(6);
            return View(product);
        }
    }
}
