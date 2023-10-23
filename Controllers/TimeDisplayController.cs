using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers;

public class TimeDisplay : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        DateTime fechaActual = DateTime.Now;
        DateTime fechaAComparar = fechaActual.AddDays(10);
        fechaAComparar = fechaAComparar.AddHours(5);
        fechaAComparar = fechaAComparar.AddMinutes(30);
        TimeSpan diferencia = fechaAComparar - fechaActual;
        ViewBag.FechaActual = fechaActual;
        ViewBag.FechaAComparar = fechaAComparar;
        ViewBag.Diferencia = diferencia;
        return View();
    }

}