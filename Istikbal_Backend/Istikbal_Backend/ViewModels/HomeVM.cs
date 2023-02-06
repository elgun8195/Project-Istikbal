using Istikbal_Backend.Models;
using System.Collections.Generic;

namespace Istikbal_Backend.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
    }
}
