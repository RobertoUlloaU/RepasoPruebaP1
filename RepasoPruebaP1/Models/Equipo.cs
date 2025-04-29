using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepasoPruebaP1.Models
{
    public class Equipo
    {
        [Key] //El ID es nuestro KEY
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Ingrese el nombre: ")]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanados { get; set; }
        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 200)]
        public int TotalPartidos
            //El set se utiliza cuando quieres asignar un valor, y el get se utiliza cuando quieres obtener un valor.
        {
            get
            {
                // Calculando el total de partidos como la suma de ganados, perdidos y empatados
                return PartidosGanados + PartidosPerdidos + PartidosEmpatados;
            }
        }


    }
}
