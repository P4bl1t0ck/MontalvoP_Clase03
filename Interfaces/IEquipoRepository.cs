using Microsoft.AspNetCore.Mvc;

namespace MontalvoP_Clase03.Interfaces
{
    public class IEquipoRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
