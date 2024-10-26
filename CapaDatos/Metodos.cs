using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Metodos
    {
        private CAPASEntities db = new CAPASEntities();

        public void Insertar(Tabla tabla)
        {
            db.Tabla.Add(tabla);
            db.SaveChanges();
        }

        public void Actualizar(int id, string nombre)
        {
            var registro = db.Tabla.Find(id);
            if (registro != null)
            {
                registro.Nombre = nombre;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var registro = db.Tabla.Find(id);
            if (registro != null)
            {
                db.Tabla.Remove(registro);
                db.SaveChanges();
            }
        }
    }
}

