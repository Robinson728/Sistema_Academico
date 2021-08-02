using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }
        public double HorasPracticas { get; set; }
        public double HorasTeoricas { get; set; }
        public int Grupo { get; set; }
        public string Prerrequisitos { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
