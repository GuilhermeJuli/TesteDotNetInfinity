using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TesteDotNetInfinity.Models;

namespace TesteDotNetInfinity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Home(){

        return View();
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult CadastroFrete(){
        
        return View();
    }

    public IActionResult Criar(){

        return View();
    }

    public IActionResult CadastroTerceiro(){

        return View();
    }

    public IActionResult ListadeEntregas(){
        return View();}
  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
