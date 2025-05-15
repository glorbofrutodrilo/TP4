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
        ViewBag.Intentos = Juego.intentos;
        ViewBag.Palabra = Juego.palabraAAdivinar;
        ViewBag.PalabraGuiones = Juego.guionesAAdivinar;
        return View();
    }
    public IActionResult arriesgarLetra(char letra)
    {
        ViewBag.PalabraGuiones = Juego.guionesAAdivinar;
        ViewBag.Intentos = Juego.intentos;
        ViewBag.Palabra = Juego.palabraAAdivinar;
      
        if (Juego.letraUsada(letra) == false)
        {
            bool esta = Juego.compararLetra(letra);
            
            if (!esta)
            {
                ViewBag.NoEsta = "La letra no esta";
            }
            else
            {
                ViewBag.Esta = "La letra esta";
            }
        }
        else
        {
            ViewBag.Error = "Error";
        }
        return View("Index.cshtml");
    }
    public IActionResult arriesgarPalabra(char [] palabra)
    {
        ViewBag.Palabra = Juego.palabraAAdivinar;
        ViewBag.Intentos = Juego.intentos;
        ViewBag.PalabraGuiones = Juego.guionesAAdivinar;

        bool esta = Juego.compararPalabra(palabra);
         if (!esta)
            {
                ViewBag.NoEsta = "La letra no esta";
            }
            else
            {
                ViewBag.Esta = "La letra esta";
            }
        return View("Index.cshtml");
    }
}
