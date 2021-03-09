using System;

namespace WebApplication2.coursework
{
    public class Order
    {
        public int Id { get; set; }

        public decimal OrderScore { get; set; }
        public DateTime OrderDateTime { get; set; } = DateTime.Today;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
