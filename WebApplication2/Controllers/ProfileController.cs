using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.coursework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication2.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfileController(ApplicationDbContext context)
        {
            _context = context;

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
        public async Task<IActionResult> Profile()
        {
            var user = await _context.Customers.FirstOrDefaultAsync(u => u.CustomerLogin == User.Identity.Name);
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == user.Id);
            if (user == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        public async Task<IActionResult> Admin()
        {
            return View(await _context.Customers.ToListAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var customer = await _context.Customers.FirstOrDefaultAsync(p => p.Id == id);
                if (customer != null)
                    return View(customer);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Profile");
        }

        [HttpGet]
        [ActionName("AdminDelete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
                if (customer != null)
                    return View(customer);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AdminDelete(int? id)
        {
            if (id != null)
            {
                var customer = new Customer { Id = id.Value };
                _context.Entry(customer).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction("Admin");
            }
            return NotFound();
        }
    }
}