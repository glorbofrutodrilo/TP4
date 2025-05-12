using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Juego.IniciarJuego();
        return View();
    }
    public IActionResult arriesgarLetra(char letra)
    {
        List<char> letrasUsadas = new List<char>();

        if (letrasUsadas.Contains(letra) == false)
        {
            bool esta = Juego.compararLetra(letra);
            
            if (!esta)
            {
                ViewBag.NoEsta = "La letra no esta";
            }
            else
            {
                for (int i = 0;i< Juego.letraspalabra; i++)
                {
                    
                }
            }
            letrasUsadas.Add(letra);
        }
        else
        {
            ViewBag.Error = "Error";
        }
        
    }
}
