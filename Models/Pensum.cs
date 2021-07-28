using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Academico.Models
{
    public class Pensum
    {
        [Key]
        public int PensumId { get; set; }
        public string Carrera { get; set; }
        public int Creditos { get; set; }
        public double HorasPracticas { get; set; }
        public double HorasTeoricas { get; set; }
        public double HorasPensum { get; set; }
        public string Semestre { get; set; }
        public DateTime FechaCreacion { get; set; }

        [ForeignKey("PensumId")]
        public virtual List<PensumDetalles> Detalle { get; set; }

        public Pensum()
        {
            PensumId = 0;
            Carrera = string.Empty;
            Creditos = 0;
            HorasPracticas = 0;
            HorasTeoricas = 0;
            HorasPensum = 0;
            Semestre = string.Empty;
            FechaCreacion = DateTime.Now;
        }
    }
}
