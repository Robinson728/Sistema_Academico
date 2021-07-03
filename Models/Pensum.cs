using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Pensum
    {
        [Key]
        public int PensumId { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
        public int Creditos { get; set; }
        public double HorasPracticas { get; set; }
        public double HorasTeoricas { get; set; }
        public string PreRequisitos { get; set; }
        public string Clave { get; set; }
        public string Semestre { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
