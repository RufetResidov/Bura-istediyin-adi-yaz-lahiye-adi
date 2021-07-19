using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        private readonly EcommerceContext _context;

        public CategoryService(EcommerceContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.Include(x=>x.Products).ToList();
        }
    }
}
