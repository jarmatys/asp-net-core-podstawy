using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_web_app.Models;
using Test_web_app.Services;
using Test_web_app.Services.Interfaces;

namespace Test_web_app.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehouseService;
        
        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

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

            var id = _warehouseService.Save(body);

            ViewData["ProductId"] = id;
            TempData["ProductId"] = id;

            return RedirectToAction("Add");
        }
    }
}
