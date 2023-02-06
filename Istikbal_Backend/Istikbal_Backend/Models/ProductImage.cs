using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istikbal_Backend.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        [NotMapped]
        public List<IFormFile> Photo { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
     
    }
}
