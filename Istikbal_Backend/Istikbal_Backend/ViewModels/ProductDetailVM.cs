using Istikbal_Backend.Models;
using System.Collections.Generic;

namespace Istikbal_Backend.ViewModels
{
    public class ProductDetailVM
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }

        public List<Product> RelatedProducts { get; set; } 
    }
}
