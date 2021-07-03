using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Profesores
    {
        [Key]
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
    }
}
