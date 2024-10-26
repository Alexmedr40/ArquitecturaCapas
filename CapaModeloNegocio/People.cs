using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloNegocio
{
    public class People
    {
        public static List<CapaDatos.Tabla> Get()
        {
            using (CapaDatos.CAPASEntities db = new CapaDatos.CAPASEntities())
            {
                return db.Tabla.ToList();
            }

        }

        private static Metodos metodos = new Metodos();

        public static void Insertar(int id, string nombre)
        {
            Tabla nuevoRegistro = new Tabla
            {
                ID = id,
                Nombre = nombre
            };
            metodos.Insertar(nuevoRegistro);
        }

        public static void Actualizar(int id, string nombre)
        {
            metodos.Actualizar(id, nombre);
        }

        public static void Eliminar(int id)
        {
            metodos.Eliminar(id);
        }
    }
}