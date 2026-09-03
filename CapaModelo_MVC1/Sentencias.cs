using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1
{
    public class Sentencias
    {
        Conexión conn = new Conexión();
        public OdbcDataAdapter llenarTbl(string nombreTabla)
        {
            string sSQL = "Select * from " + nombreTabla + " ;";
            OdbcDataAdapter daSentencias = new OdbcDataAdapter(sSQL, conn.conexion());
            return daSentencias;
        }
    }
}
