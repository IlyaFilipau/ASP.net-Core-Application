using System.Collections.Generic;

namespace WebApplication2.coursework
{
    public class Series
    {
        public int Id { get; set; }

        public string SeriesName { get; set; }
        //public Product IdSeriesNavigation { get; set; }

        public ICollection<Product> Products { get; set; }

        public Series()
        {
            Products = new List<Product>();
        }

    }
}
