using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_web_app.Models;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public ProductController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "Samochód",
                Description = "To jest super samochód",
                Name = "BMW M5"
            };

            return View(product);
        }

        public IActionResult List()
        {
            var productList = _warehouseService.GetAll();          
            return View(productList);
        }

        public IActionResult Data()
        {
            ViewBag.Name = "Jarek";
            ViewData["Surname"] = "Armatys";
            TempData["SecondName"] = "Aleksander";

            return View();
        }
    }
}
