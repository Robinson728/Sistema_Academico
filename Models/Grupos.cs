using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Academico.Models
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Asignatura { get; set; }
        public string Profesor { get; set; }
        public int CantidadEstudiantes { get; set; }
        public string Aula { get; set; }
        public int NumeroGrupo { get; set; }
    }
}
