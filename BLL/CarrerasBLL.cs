﻿using Sistema_Academico.DAL;
using Sistema_Academico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academico.BLL
{
    public class CarrerasBLL
    {
        public static bool Guardar(Carreras carrera)
        {
            if (!Existe(carrera.CarreraId))
            {
                return Insertar(carrera);
            }
            else
                return Modificar(carrera);
        }
        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Carreras.Any(e => e.CarreraId == id);
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


        private static bool Insertar(Carreras carrera)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Carreras.Add(carrera);
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

        private static bool Modificar(Carreras carrera)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(carrera).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                var carreras = contexto.Carreras.Find(id);
                if (carreras != null)
                {
                    contexto.Carreras.Remove(carreras);
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

        public static Carreras Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Carreras carreras;
            try
            {
                carreras = contexto.Carreras.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return carreras;
        }

        public static List<Carreras> GetList(Expression<Func<Carreras, bool>> criterio)
        {
            List<Carreras> lista = new List<Carreras>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Carreras.Where(criterio).ToList();
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

        public static List<Carreras> GetCarreras()
        {
            Contexto contexto = new Contexto();
            List<Carreras> lista = new List<Carreras>();

            try
            {
                lista = contexto.Carreras.ToList();
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
