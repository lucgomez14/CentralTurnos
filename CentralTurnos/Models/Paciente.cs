using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentralTurnos.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaNacimiento { get; set; }

        [Column(TypeName = "char(8)")]
        public string DNI { get; set; }
        public int NroMatricula { get; set; }
    }
}
