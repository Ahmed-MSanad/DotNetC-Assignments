using Microsoft.AspNetCore.Mvc;

namespace MVCDemo_Empty_Project.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from Index Action";
        //}

        //public ActionResult TestContentResult()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "Hello from TestContentResult";
        //    return contentResult;
        //}

        //public ActionResult TestContentHelper()
        //{
        //    return Content("Hello from TestContentHelper");
        //}

        //public string About()
        //{
        //    return "Hello from About Action";
        //}

        //public ActionResult RedirectToAbout()
        //{
        //    return RedirectToAction("About");
        //}

        //public ActionResult RedirectToLink()
        //{
        //    return Redirect("https://www.google.com");
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
