using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.Models
{
    public class SeleccionAsignatura
    {
        [Key]
        public int SeleccionId { get; set; }
        public int GrupoId { get; set; }
        public string Asignatura { get; set; }
        public string Profesor { get; set; }
        public string Aula { get; set; }
        public int CantAsignaturas { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public bool Seleccionada { get; set; }

        public SeleccionAsignatura()
        {
            SeleccionId = 0;
            GrupoId = 0;
            CantAsignaturas = 0;
            HoraInicio = DateTime.Now;
            HoraFinal = DateTime.Now;
            Seleccionada = false;
        }
    }
}
