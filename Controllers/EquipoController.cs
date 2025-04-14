using Microsoft.AspNetCore.Mvc;
using MontalvoP_Clase03.Models;

namespace MontalvoP_Clase03.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            //EquipoRepository repository = new EquipoRepository();
            //var equipos = repository.DevuelveListadoEquipos();
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2
            };
            equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8
            };
            equipos.Add(bsc);

            return View(equipos);
        }
        public IActionResult Edit(int id)
        {
            Equipo ldu = new Equipo()
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 0,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };

            return View(ldu);
        }
    }
}
