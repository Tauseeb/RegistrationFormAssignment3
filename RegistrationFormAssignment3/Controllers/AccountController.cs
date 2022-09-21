using RegistrationFormAssignment3.Models;
using Microsoft.AspNetCore.Mvc;
namespace RegistrationFormAssignment3.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User model)
        {
            if (!ModelState.IsValid)
            {

            }
            else
            {
                ViewBag.Message = "User Registration Successfully!";
            }

            return View();
        }
    }
}
