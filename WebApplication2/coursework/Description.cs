namespace WebApplication2.coursework
{
    public class Description
    {
        public int Id { get; set; }

        public string ProductDescription { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        //public Product IdProductNavigation { get; set; }
    }
}
