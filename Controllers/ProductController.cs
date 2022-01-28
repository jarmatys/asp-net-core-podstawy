using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_web_app.Models;

namespace Test_web_app.Controllers
{
    public class ProductController : Controller
    {
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
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Category = "Samochód",
                    Description = "To jest super samochód",
                    Name = "BMW M5"
                },
                new Product {
                    Id = 2,
                    Category = "Napoje",
                    Description = "To jest opis napoju",
                    Name = "PEPSI"
                },
                new Product {
                    Id = 3,
                    Category = "Roślina",
                    Description = "To jest extra roślina",
                    Name = "Storczyk"
                }
            };

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
