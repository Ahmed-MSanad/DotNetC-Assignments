using Company.Data.Models;
using Company.Service.Helper;
using Company.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signInManager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
        }
        #region SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel signupForm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = signupForm.Email.Split("@")[0],
                    Email = signupForm.Email,
                    FirstName = signupForm.FirstName,
                    LastName = signupForm.LastName,
                    IsActive = true,
                };

                var newUser = await _usermanager.CreateAsync(user, signupForm.Password);

                if (newUser.Succeeded)
                    return RedirectToAction("SignIn");

                foreach (var error in newUser.Errors)
                    ModelState.AddModelError("", error.Description);
            }
            return View(signupForm);
        }
        #endregion

        #region LogIn
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel loginForm)
        {
            if (ModelState.IsValid)
            {
                var user = await _usermanager.FindByEmailAsync(loginForm.Email);

                if (user is not null)
                {
                    if(await _usermanager.CheckPasswordAsync(user, loginForm.Password))
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, loginForm.Password, loginForm.RememberMe, true);

                        if (result.Succeeded)
                            return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Incorrect Email or Password........ .....");
            }
            return View(loginForm);
        }
        #endregion

        #region SignOut
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LogIn", "Account");
        }
        #endregion

        #region ResetPassword
        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordForm)
        {
            if (ModelState.IsValid)
            {
                var user = await _usermanager.FindByEmailAsync(forgetPasswordForm.Email);

                if (user is not null) {
                    var token = await _usermanager.GeneratePasswordResetTokenAsync(user);

                    var url = Url.Action("ResetPassword", "Account", new { 
                                                                                    Email = forgetPasswordForm.Email,
                                                                                    Token = token } ,
                                                                                    protocol: Request.Scheme,
                                                                                    host: Request.Host.Value);
                    // Here in the URL we provided a token to identify the user as we will redirect him to a page to insert his
                    //  password after he clicks the link we sent to him when he inserts the email -> so we need to know who is this ?

                    var email = new Email{ 
                        Body = url,
                        Subject = "Reset Password",
                        To = forgetPasswordForm.Email
                    };

                    EmailSettings.SendEmail(email);

                    return RedirectToAction(nameof(CheckYourInbox));
                }
            }
            return View(forgetPasswordForm);
        }

        public IActionResult CheckYourInbox()
        {
            return View();
        }
        #endregion

        #region ResetPassword

        public IActionResult ResetPassword(string Email, string Token) // Must written same as the ones given in the url
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordForm)
        {
            if (ModelState.IsValid)
            {
                var user = await _usermanager.FindByEmailAsync(resetPasswordForm.Email);

                if (user is not null)
                {
                    var result = await _usermanager.ResetPasswordAsync(user, resetPasswordForm.Token, resetPasswordForm.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(LogIn));
                    }

                    foreach (var error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(resetPasswordForm);
        }



        #endregion

    }
}
