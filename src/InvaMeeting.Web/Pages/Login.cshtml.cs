using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using InvaMeetings.Web;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using System.Security.Claims;

namespace InvaMeetings.Web.Pages
{
    public class LoginModel : PageModel
    {
        public async Task OnGet(string redirectUri)
        {
            await HttpContext.ChallengeAsync("Auth0", new AuthenticationProperties
            {
                RedirectUri = redirectUri
            });

        }
    }


}
