using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Semestres
    {
        [Key]
        public int SemestreId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; }
    }
}
