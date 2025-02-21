using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string ReturnUrl)
        {
            TempData["ReturnUrl"] = ReturnUrl;//%2Fevent%2Findex

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login userLogin)
        {
            var user = await _userManager.FindByEmailAsync(userLogin.Email);
            if (user != null)
            {
                var result = await _signInManager
                    .PasswordSignInAsync(user, userLogin.Password, false, false);

                if (result.Succeeded)
                    return Redirect(TempData["ReturnUrl"].ToString());
            }

            return View(userLogin);
        }

        //public async Task<IActionResult> AddUser()
        //{
        //    AppUser user = new AppUser();
        //    user.UserName = "admin";
        //    user.Email = "gersen.e.a@gmail.com";
        //    var result = await _userManager.CreateAsync(user, "Gg110188@");

        //    if (result.Succeeded)
        //    {

        //    }

        //    return View();
        //}
    }
}
