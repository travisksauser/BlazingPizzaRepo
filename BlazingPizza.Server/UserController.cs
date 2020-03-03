using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;

namespace BlazingPizza.Server
{
    [ApiController]
    public class UserController : Controller
    {
        private static UserInfo LoggedOutUser = new UserInfo { IsAuthenticated = false };

        [HttpGet("user")]
        public UserInfo GetUser()
        {
            return User.Identity.IsAuthenticated
                ? new UserInfo { Name = User.Identity.Name, IsAuthenticated = true }
                : LoggedOutUser;
        }
        [HttpGet("user/signin")]
        public async Task SignIn(string redirectUri, string signInService)
        {
            string[] serviceNames = { "Facebook", "Google", "Twitter"};

            // set redirect after login
            if (string.IsNullOrEmpty(redirectUri) || !Url.IsLocalUrl(redirectUri))
            {
                redirectUri = "/";
            }
            
            // if the service isnt in servicenames its either null or something else, redirect to google as default
            if (!serviceNames.Any(i => i.Equals(signInService)))
            {
                signInService = "Google";
            }

            await HttpContext.ChallengeAsync(signInService,
                        new AuthenticationProperties { RedirectUri = redirectUri });                     
        }

        [HttpGet("user/signin/guest")]
        public async Task<IActionResult> SignInGuest()
        {
            var claimsIdentity = new ClaimsIdentity(new[]
            { new Claim(ClaimTypes.Name, "Guest") }, CookieAuthenticationDefaults.AuthenticationScheme);

            //UserInfo GuestUser = new UserInfo { Name = "Guest" };

            await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties {});
            return Redirect("~/");
        }

        [HttpGet("user/signout")]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("~/");
        }
    }
}
