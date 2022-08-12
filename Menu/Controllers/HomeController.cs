using Microsoft.AspNetCore.Mvc;

namespace Menu.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}