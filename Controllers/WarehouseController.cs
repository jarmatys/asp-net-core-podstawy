using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_web_app.Models;

namespace Test_web_app.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }

            // logika do zapisu produktu

            return RedirectToAction("Add");
        }
    }
}
