using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_Academico.DAL;
using Sistema_Academico.Models;

namespace Sistema_Academico.BLL
{
    class SeleccionarBLL
    {
        public static bool Guardar(SeleccionAsignatura seleccion)
        {
            if (!Existe(seleccion.SeleccionId))
                return Insertar(seleccion);
            else
                return Modificar(seleccion);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.SeleccionAsignatura.Any(e => e.SeleccionId == id);
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


        private static bool Insertar(SeleccionAsignatura seleccion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.SeleccionAsignatura.Add(seleccion);
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

        private static bool Modificar(SeleccionAsignatura seleccion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(seleccion).State = EntityState.Modified;
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
                var seleccion = contexto.SeleccionAsignatura.Find(id);
                if (seleccion != null)
                {
                    contexto.SeleccionAsignatura.Remove(seleccion);
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

        public static SeleccionAsignatura Buscar(int id)
        {
            Contexto contexto = new Contexto();
            SeleccionAsignatura seleccion;
            try
            {
                seleccion = contexto.SeleccionAsignatura.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return seleccion;
        }

        public static List<SeleccionAsignatura> GetList(Expression<Func<SeleccionAsignatura, bool>> criterio)
        {
            List<SeleccionAsignatura> lista = new List<SeleccionAsignatura>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.SeleccionAsignatura.Where(criterio).ToList();
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

        public static List<SeleccionAsignatura> GetSelecciones()
        {
            Contexto contexto = new Contexto();
            List<SeleccionAsignatura> lista = new List<SeleccionAsignatura>();

            try
            {
                lista = contexto.SeleccionAsignatura.ToList();
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
