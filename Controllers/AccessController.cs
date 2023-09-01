using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using CrusadeServices.Models;
using CrusadeServices.Data;

namespace CrusadeServices.Controllers
{
    public class AccessController : Controller
    {
        private readonly CrusadeServicesContext _context;

        public AccessController(CrusadeServicesContext context)
        {
            _context=context;
        }

        public IActionResult Login()
        {
            //check if user already logged-in
            ClaimsPrincipal claimuser = HttpContext.User;

            if (claimuser.Identity != null && claimuser.Identity.IsAuthenticated) { return RedirectToAction("Index", "Home"); }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if(UserExists(login))
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, login.Username),
                    new Claim("Other Properties","Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = login.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }

            ViewData["ValidateMessage"] = "Invalid username / password.";
            return View();
        }
        private bool UserExists(Login login)
        {
            return (_context.User?.Any(u => u.UserName == login.Username && u.Password==login.Password)).GetValueOrDefault();
        }
    }
}
