using System.ComponentModel.DataAnnotations.Schema;

namespace CentralTurnos.Models
{
    public class Turno
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Column(TypeName = "time")]
        public DateTime Hora { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
    }
}
