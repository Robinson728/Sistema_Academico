using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.Models
{
    public  class PensumDetalles
    {
        [Key]
        public int Id { get; set; }
        public int PensumId { get; set; }
        public string Asignatura { get; set; }
        public int Practicas { get; set; }
        public int Teoricas { get; set; }
        public string Prerrequisitos { get; set; }
        public string Clave { get; set; }
        public int Creditos { get; set; }

        public PensumDetalles()
        {
            Id = 0;
            PensumId = 0;
            Asignatura = string.Empty;
            Practicas = 0;
            Teoricas = 0;
            Prerrequisitos = string.Empty;
            Clave = string.Empty;
            Creditos = 0;
        }
    }
}
