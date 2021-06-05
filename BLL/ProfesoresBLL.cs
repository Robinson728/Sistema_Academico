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
    public class ProfesoresBLL
    {
        public static bool Guardar(Profesores profesor)
        {
            if (!Existe(profesor.ProfesorId))
            {
                return Insertar(profesor);
            }
            else
                return Modificar(profesor);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Profesores.Any(e => e.ProfesorId == id);
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


        private static bool Insertar(Profesores profesor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Profesores.Add(profesor);
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

        private static bool Modificar(Profesores profesor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(profesor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                var profesor = contexto.Profesores.Find(id);
                if (profesor != null)
                {
                    contexto.Profesores.Remove(profesor);
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

        public static Profesores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Profesores Profesores;
            try
            {
                Profesores = contexto.Profesores.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Profesores;
        }

        public static List<Profesores> GetList(Expression<Func<Profesores, bool>> criterio)
        {
            List<Profesores> lista = new List<Profesores>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Profesores.Where(criterio).ToList();
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

        public static List<Profesores> GetAsignaturas()
        {
            Contexto contexto = new Contexto();
            List<Profesores> lista = new List<Profesores>();

            try
            {
                lista = contexto.Profesores.ToList();
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
