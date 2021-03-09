using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using WebApplication2.coursework;

namespace WebApplication2.Filters
{
    public class RoleFilter : Attribute, IAsyncAuthorizationFilter
    {
        public string Role { get; set; }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Roles.Load();
                var user = await db.Customers.FirstOrDefaultAsync(x => x.CustomerLogin == context.HttpContext.User.Identity.Name);
                if (user != null)
                {
                    if (user.Role.Name != Role)
                    {
                        context.HttpContext.Abort();
                    }
                }
                else
                {
                    context.HttpContext.Abort();
                }
            }
        }
    }
}
