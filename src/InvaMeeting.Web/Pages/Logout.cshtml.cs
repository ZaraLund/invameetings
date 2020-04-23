using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Security.Claims;

namespace InvaMeetings.Web.Pages
{
    public class LogoutModel : PageModel
    {
        public async Task OnGet()
        {
            Console.WriteLine($"UserId: {this.User.FindFirst(ClaimTypes.NameIdentifier).Value}");

            await HttpContext.SignOutAsync("Auth0", new AuthenticationProperties { RedirectUri = "/" });
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}