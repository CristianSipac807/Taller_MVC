using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1
{
    class Conexión
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=umg_didactica_capacitacion");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No conecto :(");
            }
            return conn;
        }
        public void desconexion(OdbcConnection conn) 
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se Desconecto : )");
            }
        }

    }
}
