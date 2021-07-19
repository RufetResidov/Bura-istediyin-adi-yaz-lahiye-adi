using FurnEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnEnd.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        public ProductController(ProductService productService, CategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int? id,int? sortBy,string search)
        {
            ShopVm sp = new()
            {
                SearchedProducts = _productService.SearchProducts(id,sortBy,search),
                Categories = _categoryService.GetCategories(),
                ProductCount = _productService.SearchProductsCount(),
                CategoryId = id,
                SortBy=sortBy
            };
            return View(sp);
        }
        public IActionResult PopupMenu(int? id)
        {
            var productDetail = _productService.GetProductByID(id.Value);
            return PartialView("_ProductPop",productDetail);
        }
        public IActionResult Details(int? Id)
        {
            if (Id == null) return NotFound();
            ProductDetailVm proVm = new()
            {
                FeaturedProduct = _productService.GetFeaturedProducts(Id.Value),
                SingleProduct = _productService.GetProductByID(Id.Value),
                SameCategoryProducts=_productService.SameCategoryProducts(Id.Value)
            };
            return View(proVm);
        }
    }
}
