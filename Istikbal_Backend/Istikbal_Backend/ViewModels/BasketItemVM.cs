using Istikbal_Backend.Models;

namespace Istikbal_Backend.ViewModels
{
    public class BasketItemVM
    {
        public Product Product { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
