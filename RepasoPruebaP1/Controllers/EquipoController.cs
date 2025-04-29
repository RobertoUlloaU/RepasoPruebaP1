using Microsoft.AspNetCore.Mvc;
using RepasoPruebaP1.Models;
using RepasoPruebaP1.Views.Repositories;  // Asegúrate de tener el espacio de nombres correcto


namespace RepasoPruebaP1.Controllers
{
    public class EquipoController : Controller
    {
        // Debes de poner el nombre que asignaste en viws Equipo
        public IActionResult List() // Acción para devolver una vista con la lista de equipos
        {
            EquipoRepository repositorio = new EquipoRepository();
            var equipos = repositorio.DevuelveListadoEquipos();
            return View(equipos);
        }

        public IActionResult EditarEquipo()
        {
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosGanados = 10,
                PartidosPerdidos = 5,
                PartidosEmpatados = 5
            };
            return View(ldu);
        }
        
    }
}

