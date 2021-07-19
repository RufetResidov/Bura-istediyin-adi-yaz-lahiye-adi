using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnEnd.ViewModels
{
    public class ProductFeaturedVm
    {
        public List<Product> Products{ get; set; }
        public List<Category> Categories{ get; set; }
    }
}
