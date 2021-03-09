using System.Collections.Generic;

namespace WebApplication2.coursework
{
    public class Genre
    {
        public int Id { get; set; }

        public string GenreName { get; set; }
        public string GenreDescription { get; set; }

        public ICollection<Product> Products { get; set; }

        public Genre()
        {
            Products = new List<Product>();
        }
    }
}
