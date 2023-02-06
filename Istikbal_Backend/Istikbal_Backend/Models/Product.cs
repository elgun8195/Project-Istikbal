using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istikbal_Backend.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public int SaleCount { get; set; }
        [NotMapped]
        public List<IFormFile> Photo { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        [NotMapped]
        public List<int> CategoryIds { get; set; }
        public List<ProductCategoryIn> ProductCategorIns { get; set; }
        [NotMapped]
        public List<int> CategoryInIds { get; set; }
    }
}
