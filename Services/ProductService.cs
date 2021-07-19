 using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ProductService
    {
        private readonly EcommerceContext _context;

        public ProductService(EcommerceContext context)
        {
            _context = context;
        }
        public List<Product> GetProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").ToList();
        }

        public List<Product> GetFeaturedProducts(int id)
        {
            return _context.Products.Where(x => x.isFeatured && x.ID != id).Include("ProductPictures.Picture").ToList();
        }
        public List<Product> SameCategoryProducts(int id)
        {
            var selectedProduct = GetProductByID(id);
            return _context.Products.Where(x => x.isFeatured && x.ID != id).Include("ProductPictures.Picture").ToList();
        }
        public int SearchProductsCount()
        {
            var productList = _context.Products.AsQueryable();
            return productList.Count();
        }
        public List<Product> SearchProducts(int? id, int? sortBy,string search)
        {
            var productList = _context.Products.AsQueryable();
            if (id.HasValue)
            {
                productList = productList.Where(x => x.CategoryID == id);
            }
            if (sortBy.HasValue)
            {
                switch (sortBy)
                {
                    case 1:
                        productList = productList.OrderByDescending(x => x.Price);
                        break;
                    case 2:
                        productList = productList.OrderBy(x => x.Price);
                        break;
                    case 3:
                        productList = productList.OrderByDescending(x => x.Name);
                        break;
                    default:
                        productList = productList.OrderBy(x => x.Name);
                        break;
                }
            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                productList = productList.Where(x => x.Name.StartsWith(search));    
            }
            return productList.Include("ProductPictures.Picture").ToList();
        }
        public Product GetProductByID(int? Id)
        {
            return _context.Products.Include("ProductPictures.Picture").FirstOrDefault(x => x.ID == Id);
        }
    }
}
