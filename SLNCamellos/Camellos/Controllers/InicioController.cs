using Microsoft.AspNetCore.Mvc;
using System.Configuration

namespace Camellos.Controllers
{
    public class InicioController : Controller
    {
    



        public IActionResult Inicio()
        {
            return View();
        }
    }
}
