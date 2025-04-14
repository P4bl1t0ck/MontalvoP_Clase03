using Microsoft.AspNetCore.Mvc;

namespace MontalvoP_Clase03.Repositorios
{
    public class EquipoRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
