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
    public class PensumBLL
    {
        public static bool Guardar(Pensum pensums)
        {
            if (!Existe(pensums.PensumId))
            {
                return Insertar(pensums);
            }
            else
                return Modificar(pensums);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Pensum.Any(e => e.PensumId == id);
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


        private static bool Insertar(Pensum pensums)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Pensum.Add(pensums);
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

        private static bool Modificar(Pensum pensums)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete from PensumDetalles where PensumId = {pensums.PensumId}");

                foreach (var item in pensums.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(pensums).State = EntityState.Modified;
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
                var pensum = contexto.Pensum.Find(id);
                if (pensum != null)
                {
                    contexto.Entry(pensum).State = EntityState.Deleted;
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

        public static Pensum Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pensum Pensum;
            try
            {
                Pensum = contexto.Pensum.Include(r => r.Detalle).Where(r => r.PensumId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Pensum;
        }

        public static List<Pensum> GetList(Expression<Func<Pensum, bool>> criterio)
        {
            List<Pensum> lista = new List<Pensum>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Pensum.Where(criterio).ToList();
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

        public static List<Pensum> GetPensum()
        {
            Contexto contexto = new Contexto();
            List<Pensum> lista = new List<Pensum>();

            try
            {
                lista = contexto.Pensum.ToList();
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
