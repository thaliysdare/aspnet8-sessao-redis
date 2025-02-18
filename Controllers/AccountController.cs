using Microsoft.AspNetCore.Mvc;

namespace aspnet8_sessao_redis.Controllers;

public class AccountController : Controller
{
    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "password")
        {
            HttpContext.Session.SetString("User", username);
            return RedirectToAction(nameof(HomeController.Privado), nameof(HomeController)[..^10]);
        }
        ViewBag.Message = "Credenciais inválidas";
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction(nameof(Login));
    }

}
