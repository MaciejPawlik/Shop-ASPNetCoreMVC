using System.Collections.Generic;
using Shop.Models;

namespace Shop.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Car> Cars { get; set; }
    }
}
