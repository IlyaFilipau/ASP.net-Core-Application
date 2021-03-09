using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WebApplication2.coursework
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string LogoUrl { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductIssueDate { get; set; }
        public int ProductEvaluation { get; set; }
        public string ProductAgeRating { get; set; }
        public string ProductDescription { get; set; }

        public int SeriesId { get; set; }
        public Series Series { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int GenreId { get; set; }
        public  Genre Genre { get; set; }

        //public ICollection<Order> Orders { get; set; }
        //public ICollection<Image> Images { get; set; }
        public ICollection<Review> Reviews { get; set; }
        //public ICollection<Description> Descriptions { get; set; }

        public Product()
        {
        //    Orders = new List<Order>();
        //    Images = new List<Image>();
            Reviews = new List<Review>();
        //    Descriptions = new List<Description>();
        }

        public void Update(Product product)
        {
            ProductName = product.ProductName;
            LogoUrl = product.LogoUrl;
            Price = product.Price;
            ProductIssueDate = product.ProductIssueDate;
            ProductEvaluation = product.ProductEvaluation;
            ProductAgeRating = product.ProductAgeRating;
            ProductDescription = product.ProductDescription;
            SeriesId = product.SeriesId;
            //Series = product.Series;
            ManufacturerId = product.ManufacturerId;
            //Manufacturer = product.Manufacturer;
            PublisherId = product.PublisherId;
            //Publisher = product.Publisher;
            CategoryId = product.CategoryId;
            //Category = product.Category;
            GenreId = product.GenreId;
            //Genre = product.Genre;
            //Reviews = product.Reviews;
        }

        public enum SortState
        {
            NameAsc,
            NameDesc,
            PriceAsc,
            PriceDesc
        }

    }

}
