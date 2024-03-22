using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            //var modelo = new TipoCuenta() { Nombre = "Felipe" };
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta) 
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }
            return View(); 
        }
    }
}
