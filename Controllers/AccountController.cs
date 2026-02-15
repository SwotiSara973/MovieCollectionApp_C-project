using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Movie_Collection_App.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            // Authentication Step
            if (Username == "admin" && Password == "password123")
            {
                HttpContext.Session.SetString("UserName", Username);
                TempData["LoginSuccess"] = "Successfully Authenticated!";
                return RedirectToAction("Index", "Dashboard");
            }

            // If login fails, set the error message seen in your screenshot
            ViewBag.Error = "Invalid credentials. Please try again.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}