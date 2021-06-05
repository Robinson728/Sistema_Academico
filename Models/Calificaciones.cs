using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Calificaciones
    {
        [Key]
        public int EstudianteId { get; set; }
        public string NombreEstudiante { get; set; }
        public int MatriculaEstudiante { get; set; }
        public double CalificacionFinal { get; set; }
    }
}
