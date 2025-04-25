using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp_03_Musica.Models;

namespace Tp_03_Musica.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        inicializarDisco.Cargardiscos();
        ViewBag.diccio = inicializarDisco.Cargardiscos();
        return View();
    }
     public IActionResult MostrarTemas(string key)
    {
         Dictionary<string, disco> diccio = inicializarDisco.Cargardiscos();
        ViewBag.temasDiscoDeterminado = diccio[key].temas;
        return View();
    }
    
}
