using DataAccess;
using FurnEnd.ViewModels;
using FurnEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Services;

namespace FurnEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        public HomeController(ILogger<HomeController> logger, ProductService productService, CategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ProductFeaturedVm proVm = new ProductFeaturedVm()
            {
                Categories=_categoryService.GetCategories(), 
                Products=_productService.GetProducts()
            };
            return View(proVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
