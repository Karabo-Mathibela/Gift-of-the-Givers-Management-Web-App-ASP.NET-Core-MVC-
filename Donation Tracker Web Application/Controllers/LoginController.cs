using LoginAndRegistration.Models;
using LoginAndRegistration.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class LoginController : Controller
    {
        //THESE ARE THE DEPENDECIES TO BE INJECTED INTO THIS CONTROLLER:
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        //CONSTRUCTOR INJECTION:
        public LoginController(UserManager<AppUser> userMgr, SignInManager<AppUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [HttpGet]
        public IActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginView(UserModel userModel)
        {

            AppUser appUser = await userManager.FindByNameAsync(userModel.Username);

            if (appUser == null)
            {
                ViewBag.UserErrorMessage = "User not found";
                ViewBag.UserError = true;
            }

            // 2. Correctly verify the password using UserManager
            bool passwordValid = await userManager.CheckPasswordAsync(appUser, userModel.Password);

            if (passwordValid)
            {
                // Sign the user in (this is often a separate step after validation,
                // but for this simple example, we assume successful authentication)

                // Note: For a real application, you'd call:
                // await signInManager.SignInAsync(appUser, isPersistent: false);
                ViewBag.LoginError = false;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginErrorMessage = "Incorrect password.";
                ViewBag.LoginError = true;
            }

            return View(userModel);
        } 
    }
}
