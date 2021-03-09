using System.Collections.Generic;

namespace WebApplication2.coursework
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
