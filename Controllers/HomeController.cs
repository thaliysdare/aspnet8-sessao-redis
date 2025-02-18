using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnet8_sessao_redis.Models;

namespace aspnet8_sessao_redis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Privado()
    {
        if (HttpContext.Session.GetString("User") is null)
            return RedirectToAction(nameof(AccountController.Login), nameof(AccountController)[..^10]);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => 
        View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
