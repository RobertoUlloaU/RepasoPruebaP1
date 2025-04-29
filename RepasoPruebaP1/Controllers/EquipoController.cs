using Microsoft.AspNetCore.Mvc;
using RepasoPruebaP1.Models;  // Asegúrate de tener el espacio de nombres correcto


namespace RepasoPruebaP1.Controllers
{
    public class EquipoController : Controller
    {
        // Debes de poner el nombre que asignaste en viws Equipo
        public IActionResult List()
        {
            // Crear la lista de equipos
            List<Equipo> equipos = new List<Equipo>();

            // Crear equipos con sus datos
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosGanados = 10,
                PartidosPerdidos = 5,
                PartidosEmpatados = 5
            };

            // Crear más equipos y agregar a la lista
            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosGanados = 12,
                PartidosPerdidos = 3,
                PartidosEmpatados = 5
            };

            Equipo aucas = new Equipo
            {
                Id = 3,
                Nombre = "Aucas",
                PartidosGanados = 8,
                PartidosPerdidos = 7,
                PartidosEmpatados = 5
            };

            // Agregar los equipos a la lista
            equipos.Add(ldu);
            equipos.Add(barcelona);
            equipos.Add(aucas);

            // Pasar la lista de equipos a la vista
            return View(equipos);
        }
    }
}

