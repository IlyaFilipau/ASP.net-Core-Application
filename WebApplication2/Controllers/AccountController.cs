    using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication2.coursework;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
            _context.Roles.Load();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Login))
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                Customer customer = await _context.Customers.FirstOrDefaultAsync(u =>
                    u.CustomerLogin == model.Login && u.CustomerPassword == model.Password);

                if (customer != null)
                {
                    await Authenticate(customer.CustomerLogin, customer.Role.Name);

                    return RedirectToAction("Products", "Home");
                }
            }
            ModelState.AddModelError("", "Wrong login and(or) password");
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (model.Login == model.Password)
            {
                ModelState.AddModelError("", "Login and password must not match");
            }

            if (!ModelState.IsValid) return View(model);
            var user = await _context.Customers.FirstOrDefaultAsync(x => x.CustomerLogin == model.Login
                                                                         && x.CustomerPassword == model.Password);
            if (user == null)
            {
                _context.Customers.Add(new Customer { CustomerLogin = model.Login, CustomerEmail = model.Email, CustomerPassword = model.Password });
                await _context.SaveChangesAsync();
                await Authenticate(model.Login, "user");
                
                return RedirectToAction("Login", "Account");
            }
                ModelState.AddModelError("", "Uncorrect login and(or) password");
            return View(model);
        }

        private async Task Authenticate(string userName, string role)
        {
            var claims = new List<Claim>
            {
            new Claim(ClaimsIdentity.DefaultNameClaimType, userName),
            new Claim(ClaimsIdentity.DefaultNameClaimType, role)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}