using Microsoft.EntityFrameworkCore;
using Sistema_Academico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Asignaturas> Asigatura { get; set; }

        public DbSet<Calificaciones> Calificacion { get; set; }
        public DbSet<Carreras> Carrera { get; set; }
        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Grupos> Grupo { get; set; }
        public DbSet<Pensum> Pensums { get; set; }
        public DbSet<Profesores> Profesor { get; set; }
        public DbSet<Semestres> Semestre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\GestionAcademico.db");
        }
    }
}
