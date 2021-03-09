using System.Collections.Generic;

namespace WebApplication2.coursework
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerLogin { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerEmail { get; set; }
        public double CustomerScore { get; set; }

        public int RoleId { get; set; } = 2;
        public Role Role { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Customer()
        {
            Reviews = new List<Review>();
            Orders = new List<Order>();
            CustomerScore = 0;
        }
    }
}
