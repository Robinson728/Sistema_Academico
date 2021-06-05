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
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Calificaciones> Calificaciones { get; set; }
        public DbSet<Carreras> Carreras { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<Pensum> Pensum { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Semestres> Semestres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\GestionAcademico.db");
        }
    }
}
