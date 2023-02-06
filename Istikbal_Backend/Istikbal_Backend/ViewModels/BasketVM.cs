using System.Collections.Generic;

namespace Istikbal_Backend.ViewModels
{
    public class BasketVM
    {
        public List<BasketItemVM> BasketItems { get; set; }
        public int TotalPrice { get; set; }
        public int Count { get; set; }
    }
}
