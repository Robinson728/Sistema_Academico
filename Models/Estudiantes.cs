using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public int Matricula { get; set; }
        public int Telefono { get; set; }
        public string Carrera { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo { get; set; }
    }
}
