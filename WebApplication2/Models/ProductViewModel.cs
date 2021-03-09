using System.Collections.Generic;
using WebApplication2.coursework;

namespace WebApplication2.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public SortViewModel SortViewModel { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
    }
}