using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using WebBeacon.Models;
using WebBeacon.Infrastructure;

namespace WebBeacon.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl) {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel, string returnUrl) {
            if (LoginUser(loginModel.Username, loginModel.Password)) {
                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, loginModel.Username)
            };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("CookieAuth", principal);

                //Just redirect to our index after logging in. 
                //return Redirect("/user/");
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));

            }
            return View();
        }

        private bool LoginUser(string username, string password) {
            //find user in de database otherwise return false

            //User loginUser = RepositoryUsers.Users.FirstOrDefault(s => s.Email == username);
            using (var db = new BeaconContext()) {

                User loginUser = db.Users.FirstOrDefault(s => s.Email == username);
                //Beacon AccessedBeacon = db.Beacons.FirstOrDefault(s => s.BeaconGuid == BeaconGuidFromRequest);


                if (loginUser != null) {

                    if (loginUser.PasswordHash == password) {

                        return true;

                    } else {

                        return false;

                    }

                } else {

                    return false;

                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout() {
            //await HttpContext.Authentication.SignOutAsync("CookieAuthentication");
            await HttpContext.SignOutAsync("CookieAuth");
            return Redirect("/Home/Index");
        }

        public ViewResult Register() {

            //create viewmodel AccountRegister

            return View(new RegisterViewModel() { Name = "Jan", Email = "j.jansen@top.nl" });
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel aRegisterViewModel) {

            //create viewmodel AccountRegister

            if (ModelState.IsValid) {

                User aNewUser = new User();
                //copy attibutes to new user
                aNewUser.Email = aRegisterViewModel.Email;
                aNewUser.Name = aRegisterViewModel.Name;
                aNewUser.PasswordHash = aRegisterViewModel.Password;



                //RepositoryUsers.Save(aNewUser);
                return RedirectToAction("Index", "Home");

            } else {

                return View(aRegisterViewModel);
            }




        }
    }





}