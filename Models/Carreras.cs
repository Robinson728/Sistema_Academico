using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Carreras
    {
        [Key]
        public int CarreraId { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int TotalAsignaturas { get; set; }
        public double HorasPensum { get; set; }
        public double HorasPracticas { get; set; }
        public double HorasTeoricas { get; set; }
        public double Duracion { get; set; }
        public int SemestresAcademicos { get; set; }
        public int TotalAsignaturasElectivas { get; set; }
        public string TituloOtorgado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
