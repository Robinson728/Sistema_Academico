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
    public class SemestresBLL
    {
        public static bool Guardar(Semestres semestre)
        {
            if (!Existe(semestre.SemestreId))
            {
                return Insertar(semestre);
            }
            else
                return Modificar(semestre);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Semestres.Any(e => e.SemestreId == id);
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


        private static bool Insertar(Semestres semestre)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Semestres.Add(semestre);
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

        private static bool Modificar(Semestres semestre)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(semestre).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                var semestre = contexto.Semestres.Find(id);
                if (semestre != null)
                {
                    contexto.Semestres.Remove(semestre);
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

        public static Semestres Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Semestres Semestres;
            try
            {
                Semestres = contexto.Semestres.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Semestres;
        }

        public static List<Semestres> GetList(Expression<Func<Semestres, bool>> criterio)
        {
            List<Semestres> lista = new List<Semestres>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Semestres.Where(criterio).ToList();
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
    }
}
