using Microsoft.EntityFrameworkCore;
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
    public class AsignaturasBLL
    {

        public static bool Guardar(Asignaturas asignatura)
        {
            if (!Existe(asignatura.AsignaturaId))
                return Insertar(asignatura);
            else
                return Modificar(asignatura);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Asignaturas.Any(e => e.AsignaturaId == id);
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


        private static bool Insertar(Asignaturas asignatura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Asignaturas.Add(asignatura);
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

        private static bool Modificar(Asignaturas asignatura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(asignatura).State = EntityState.Modified;
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
                var asignatura = contexto.Asignaturas.Find(id);
                if (asignatura != null)
                {
                    contexto.Asignaturas.Remove(asignatura);
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

        public static Asignaturas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Asignaturas Asignaturas;
            try
            {
                Asignaturas = contexto.Asignaturas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Asignaturas;
        }

        public static List<Asignaturas> GetList(Expression<Func<Asignaturas, bool>> criterio)
        {
            List<Asignaturas> lista = new List<Asignaturas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Asignaturas.Where(criterio).ToList();
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

        public static List<Asignaturas> GetAsignaturas()
        {
            Contexto contexto = new Contexto();
            List<Asignaturas> lista = new List<Asignaturas>();

            try
            {
                lista = contexto.Asignaturas.ToList();
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
