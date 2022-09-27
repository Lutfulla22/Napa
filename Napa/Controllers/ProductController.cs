using Microsoft.AspNetCore.Mvc;
using Napa.Models;
using Napa.Services;
using Napa.ViewModels;

namespace Napa.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var product = await _service.GetAll();
            return View(product);
        }
        public IActionResult Create()
        {
            return View(new ProductVM());
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title,Quantiy,Price")]Product products)
        {
            if (!ModelState.IsValid)
            {
                return View(products);
            }
            await _service.InsertAsync(products);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _service.GetAsync(id);
            if(product == null) return View("Error");
            return View(product);
        }

    }
}
