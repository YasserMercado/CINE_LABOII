using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Cine.Acceso
{
    public abstract class Acceso
    {
        private readonly string conexion;

        public Acceso()
        {
            conexion = "Data Source=DESKTOP-47S0GDS;Initial Catalog=CINE_CORDOBA;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }


    }
}
