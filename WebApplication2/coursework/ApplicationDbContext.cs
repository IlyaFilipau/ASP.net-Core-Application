using Microsoft.EntityFrameworkCore;

namespace WebApplication2.coursework
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Series> Series { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var adminRoleName = "admin";
            var userRoleName = "user";

            var adminEmail = "admin@mail.ru";
            var adminPassword = "123456";

            // добавляем роли
            var adminRole = new Role { Id = 1, Name = adminRoleName };
            var userRole = new Role { Id = 2, Name = userRoleName };
            var adminUser = new Customer { Id = 1, CustomerEmail = adminEmail, CustomerPassword = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<Customer>().HasData(new Customer[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=coursework;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
               // optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=root;database=my_coursework");
            }
        }
    }
}
