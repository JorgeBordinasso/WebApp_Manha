using Microsoft.AspNetCore.Mvc;

namespace WebApp_Manha.Controllers
{
    public class Clientes : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
