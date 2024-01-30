using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace Camellos.Controllers
{
    public class InicioController : Controller
    {
    
        


        public IActionResult Pagina()
        {
            return View();
        }

        public IActionResult Logear()
        {
            return View();
        }
        public IActionResult Aviso()
        {
            return View();
        }
    }
}
