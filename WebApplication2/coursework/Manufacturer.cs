using System.Collections.Generic;

namespace WebApplication2.coursework
{
    public class Manufacturer
    {
        public int Id { get; set; }
        
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }
        public double ManufacturerRating { get; set; }
        public string ManufacturerEmail { get; set; }

        public ICollection<Product> Products { get; set; }

        public Manufacturer()
        {
            Products = new List<Product>();
        }
    }
}
