using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istikbal_Backend.Models
{
    public class CategoryIn:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public List<CategoryDest> CategoryDests { get; set; }
        public List<ProductCategoryIn> ProductCategoryIns { get; set; }

    }
}
