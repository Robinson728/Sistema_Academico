using Sistema_Academico.DAL;
using Sistema_Academico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.BLL
{
    class CalificacionesBLL
    {
        public static bool Guardar(Calificaciones calificaciones)
        {
            if (!Existe(calificaciones.EstudianteId))
            {
                return Insertar(calificaciones);
            }
            else
                return Modificar(calificaciones);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Calificaciones.Any(e => e.EstudianteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }


        private static bool Insertar(Calificaciones calificaciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Calificaciones.Add(calificaciones);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Calificaciones calificaciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(calificaciones).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var calificaciones = contexto.Calificaciones.Find(id);
                if (calificaciones != null)
                {
                    contexto.Calificaciones.Remove(calificaciones);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Calificaciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Calificaciones Calificaciones;
            try
            {
                Calificaciones = contexto.Calificaciones.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Calificaciones;
        }

        public static List<Calificaciones> GetList(Expression<Func<Calificaciones, bool>> criterio)
        {
            List<Calificaciones> lista = new List<Calificaciones>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Calificaciones.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
