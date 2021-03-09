using System.Collections.Generic;

namespace WebApplication2.coursework
{
    public class Publisher
    {
        public int Id { get; set; }

        public string PublisherName { get; set; }
        public string PublisherDescription { get; set; }

        public ICollection<Product> Products { get; set; }

        public Publisher()
        {
            Products = new List<Product>();
        }
    }
}
