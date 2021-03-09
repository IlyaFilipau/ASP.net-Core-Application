using System.Collections.Generic;
using WebApplication2.coursework;

namespace WebApplication2.ViewModel
{
    public class ProductView
    {
        public Product Product { get; set; }
        public IList<Genre> Genres { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Manufacturer> Manufacturers { get; set; }
        public IList<Publisher> Publishers { get; set; }
        public IList<Series> Series { get; set; }

        public ProductView(Product product, IList<Genre> genres, IList<Category> categories, IList<Manufacturer> manufacturers, IList<Publisher> publishers, IList<Series> series)
        {
            Product = product;
            Genres = genres;
            Categories = categories;
            Manufacturers = manufacturers;
            Publishers = publishers;
            Series = series;
        }
    }
}
