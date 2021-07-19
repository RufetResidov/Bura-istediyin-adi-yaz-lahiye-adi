using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnEnd.ViewModels
{
    public class ProductDetailVm
    {
        public Product SingleProduct { get; set; }
        public List<Product> FeaturedProduct { get; set; }
        public List<Product> SameCategoryProducts { get; set; }
    }
}
