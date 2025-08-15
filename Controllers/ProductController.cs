using FirstWebApp.Models;
using FirstWebApp.Services.Implementation;
using FirstWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _Service;

        public ProductController(IProductService Service)
        {
            _Service = Service;

        }
        public IActionResult Index()
        {
            var Products = _Service.GetProducts();
            ViewBag.Count = Products.Count();
            return View(Products);
        }

        public IActionResult Detials(int id)
        {
            var Product = _Service.GetProductById(id);
            return View(Product);
        }
    }
}
