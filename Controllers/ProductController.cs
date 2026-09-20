using HomeEase.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeEase.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
