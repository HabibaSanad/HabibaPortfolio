using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetSkills()
        {
            return View();
        }

        public IActionResult GetProjects()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About Me";
            return View();
        }

        public IActionResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitContactForm(string name, string email, string message)
        {
            ViewBag.Message = $"Thank you for contacting us, {name}! We will get back to you shortly.";
            return View("ContactMe");
        }
    }
}
