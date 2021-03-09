using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.coursework;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using WebApplication2.Filters;
using WebApplication2.ViewModel;
using static WebApplication2.coursework.Product;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        public HomeController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

            _context.Customers.Load();
            _context.Products.Load();
            _context.Descriptions.Load();
            _context.Genres.Load();
            _context.Series.Load();
            _context.Categories.Load();
            _context.Manufacturers.Load();
            _context.Publishers.Load();
            _context.Orders.Load();
            _context.Reviews.Load();
            _context.Roles.Load();
        }
        [Authorize]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Content(User.Identity.Name);
            }
            return Content("Don't authenticated");

        }

        public IActionResult About()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Products(int? genre, string name, int page = 1, SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 5;

            IQueryable<Product> products = _context.Products.Include(x => x.Genre);

            if (genre != null && genre != 0)
            {
                products = products.Where(p => p.GenreId == genre);
            }
            if (!String.IsNullOrEmpty(name))
            {
                products = products.Where(p => p.ProductName.Contains(name));
            }

            switch (sortOrder)
            {
                case SortState.NameDesc:
                    products = products.OrderByDescending(s => s.ProductName);
                    break;
                case SortState.PriceAsc:
                    products = products.OrderBy(s => s.Price);
                    break;
                case SortState.PriceDesc:
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.ProductName);
                    break;
            }

            // пагинация
            var count = await products.CountAsync();
            var items = await products.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            //PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            ProductViewModel viewModel = new ProductViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(_context.Genres.ToList(), genre, name),
                Products = items
            };
            return View(viewModel);
        }
      
        [RoleFilter(Role = "admin")]
        public IActionResult AddProduct()
        {
            var genres = _context.Genres.ToList();
            var series = _context.Series.ToList();
            var categories = _context.Categories.ToList();
            var manufacturers = _context.Manufacturers.ToList();
            var publishers = _context.Publishers.ToList();

            var model = new AddProduct()
            {
                Genres = genres,
                Series = series,
                Categories = categories,
                Manufacturers = manufacturers,
                Publishers = publishers,
                Product = new Product()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product, IFormFile logo)
        {
            if (ModelState.IsValid)
            {
                //эта логика должна быть не тут, потом перенесешь
                var logoUrl = Path.Combine("images", logo.FileName);
                using (var stream = new StreamWriter(Path.Combine(_env.WebRootPath, logoUrl)))
                {
                    logo.CopyTo(stream.BaseStream);
                }

                product.LogoUrl = logoUrl;

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Products");
            }
            return RedirectToAction("AddProduct");
        }

        [HttpGet]
        public async Task<IActionResult> AddReview(int? productId)
        {
            if (ModelState.IsValid)
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
                var user = await _context.Customers.FirstOrDefaultAsync(u => u.CustomerLogin == User.Identity.Name);
                var review = await _context.Reviews.FirstOrDefaultAsync(u => u.CustomerId == user.Id && u.ProductId == productId);
                if (review != null)
                {
                    return View(review);
                }
                if (product != null)
                {
                    return View();
                }
            }
            return RedirectToAction("AddReview");
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(Review review, int? id, int? productId)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Customers.FirstOrDefaultAsync(u => u.CustomerLogin == User.Identity.Name);
                var entity = await _context.Reviews.FirstOrDefaultAsync(u => u.Id == id);
                var reviews = await _context.Reviews.FirstOrDefaultAsync(u => u.CustomerId == user.Id && u.ProductId == productId);
                if (entity != null)
                {
                    _context.Reviews.Update(review);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details");
                }
                _context.Reviews.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details");
            }
            return RedirectToAction("AddReview");
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [RoleFilter(Role = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var genres = _context.Genres.ToList();
                var series = _context.Series.ToList();
                var categories = _context.Categories.ToList();
                var manufacturers = _context.Manufacturers.ToList();
                var publishers = _context.Publishers.ToList();

                var model = new AddProduct()
                {
                    Genres = genres,
                    Series = series,
                    Categories = categories,
                    Manufacturers = manufacturers,
                    Publishers = publishers,
                    Product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id)
                };
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product, IFormFile logo)
        {
            if (ModelState.IsValid)
            {
                var logoUrl = Path.Combine("images", logo.FileName);
                using (var stream = new StreamWriter(Path.Combine(_env.WebRootPath, logoUrl)))
                {
                    logo.CopyTo(stream.BaseStream);
                }

                product.LogoUrl = logoUrl;

                var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == product.Id);

                if (entity != null)
                {
                    entity.Update(product);
                    _context.Products.Update(entity);
                    _context.SaveChanges();
                }
            return RedirectToAction("Products");
            }
            return RedirectToAction("Edit");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                    return View(product);
            }
            return NotFound();
        }

        //ого принимать объект в GET методе, сильно
        public async Task<IActionResult> Buy(int? productId)
        {
            if (productId == null || User.Identity.IsAuthenticated == false)
            {
                return NotFound();
            }

            var user = await _context.Customers.FirstOrDefaultAsync(u => u.CustomerLogin == User.Identity.Name);
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.CustomerId == user.Id && o.ProductId == product.Id);
            if (order == null)
            { 
            if (product != null && user != null)
            {
                _context.Orders.Add(new Order{CustomerId = user.Id, ProductId = product.Id, OrderScore = product.Price} );
                await _context.SaveChangesAsync();
                return RedirectToAction("Profile", "Profile");
            }
            return NotFound();
            }
            return RedirectToAction("Profile", "Profile");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {

                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                _context.Entry(product).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction("Products");
            }
            return NotFound();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}