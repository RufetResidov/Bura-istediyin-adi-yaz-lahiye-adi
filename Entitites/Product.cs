using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Product:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal? Discount { get; set; }
        public bool isFeatured { get; set; }
        public bool isNew { get; set; }
        public int ThumbnailPictureID { get; set; }
        public string Sku { get; set; }
        public string Tags { get; set; }
        public string Barcode { get; set; }
        public string Supplier { get; set; }
        public virtual List<ProductPicture>ProductPictures{ get; set; }
    }
}
