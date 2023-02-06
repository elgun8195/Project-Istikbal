using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istikbal_Backend.Models
{
    public class Category:BaseEntity
    { 
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

        public List<CategoryDest> CategoryDests { get; set; }

        [NotMapped]
        public List<int> CategoryIds { get; set; }
        [NotMapped]
        public List<int> CategoryInIds { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
