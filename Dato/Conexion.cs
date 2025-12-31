using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class Conexion
    {
        string cadenaConexion = "data source=.; initial catalog=SISTEMA_INVENTARIO; integrated security=true; TrustServerCertificate= true;";
        public SqlConnection conectar () {
            return new SqlConnection(cadenaConexion);
        
        }
    }


}
