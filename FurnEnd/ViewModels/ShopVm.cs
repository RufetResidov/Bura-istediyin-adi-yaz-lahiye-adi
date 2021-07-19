using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnEnd.ViewModels
{
    public class ShopVm
    {
        public int? CategoryId { get; set; }
        public int ProductCount { get; set; }
        public int? SortBy { get; set; }
        public List<Product>SearchedProducts{ get; set; }
        public List<Category>Categories{ get; set; }
    }
}
