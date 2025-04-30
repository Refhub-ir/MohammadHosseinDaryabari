using Microsoft.AspNetCore.Mvc;

namespace Refhub.Areas.User.Controllers;

[Area("User")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
