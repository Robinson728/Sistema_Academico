using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Academico.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Creditos = table.Column<int>(type: "INTEGER", nullable: false),
                    Grupo = table.Column<int>(type: "INTEGER", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HoraFinal = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreEstudiante = table.Column<string>(type: "TEXT", nullable: true),
                    MatriculaEstudiante = table.Column<int>(type: "INTEGER", nullable: false),
                    CalificacionFinal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    CarreraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Creditos = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalAsignaturas = table.Column<int>(type: "INTEGER", nullable: false),
                    HorasPensum = table.Column<double>(type: "REAL", nullable: false),
                    HorasPracticas = table.Column<double>(type: "REAL", nullable: false),
                    HorasTeoricas = table.Column<double>(type: "REAL", nullable: false),
                    Duracion = table.Column<double>(type: "REAL", nullable: false),
                    SemestresAcademicos = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalAsignaturasElectivas = table.Column<int>(type: "INTEGER", nullable: false),
                    TituloOtorgado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.CarreraId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Matricula = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Asignatura = table.Column<string>(type: "TEXT", nullable: true),
                    Profesor = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadEstudiantes = table.Column<int>(type: "INTEGER", nullable: false),
                    Aula = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroGrupo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "Pensum",
                columns: table => new
                {
                    PensumId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true),
                    Asignatura = table.Column<string>(type: "TEXT", nullable: true),
                    Creditos = table.Column<int>(type: "INTEGER", nullable: false),
                    HorasPracticas = table.Column<double>(type: "REAL", nullable: false),
                    HorasTeoricas = table.Column<double>(type: "REAL", nullable: false),
                    PreRequisitos = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Semestre = table.Column<string>(type: "TEXT", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pensum", x => x.PensumId);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    ProfesorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.ProfesorId);
                });

            migrationBuilder.CreateTable(
                name: "Semestres",
                columns: table => new
                {
                    SemestreId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestres", x => x.SemestreId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Pensum");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Semestres");
        }
    }
}
