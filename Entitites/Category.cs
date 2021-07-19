using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public  string Icon { get; set; }
        public List<Product> Products { get; set; }
    }
}
