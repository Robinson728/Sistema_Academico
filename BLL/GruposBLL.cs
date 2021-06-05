using Sistema_Academico.DAL;
using Sistema_Academico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.BLL
{
    class GruposBLL
    {
        public static bool Guardar(Grupos grupo)
        {
            if (!Existe(grupo.GrupoId))
            {
                return Insertar(grupo);
            }
            else
                return Modificar(grupo);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Grupos.Any(e => e.GrupoId == id);
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


        private static bool Insertar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Grupos.Add(grupo);
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

        private static bool Modificar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(grupo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                var grupos = contexto.Grupos.Find(id);
                if (grupos != null)
                {
                    contexto.Grupos.Remove(grupos);
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

        public static Grupos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Grupos Grupos;
            try
            {
                Grupos = contexto.Grupos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Grupos;
        }

        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> criterio)
        {
            List<Grupos> lista = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Grupos.Where(criterio).ToList();
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
