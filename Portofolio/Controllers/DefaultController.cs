using Microsoft.AspNetCore.Mvc;
namespace Portofolio.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}