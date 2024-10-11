using Microsoft.AspNetCore.Mvc;

namespace MouseMouvementAPI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
