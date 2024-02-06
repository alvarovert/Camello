using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Camellos.Models;

namespace Camellos.Controllers
{
    public class AccesoController : Controller
    {
   
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string NDocumento, string Password)
        {
            if (NDocumento == "ALVARO")
            {
                return RedirectToAction("Index", "Home");
            }
            else {
                return View();
            }


        }
    }
}
