using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHoteles
{
    public class conexion
    {
        public static string Conexion = "Server = localhost; Database = reservacion_hoteles; Uid = root; Pwd =;";
        
        //get conexion
        public static string getConexion()
        {
            return Conexion;
        }

        //set conexion
        public static void setConexion(string nuevaConexion)
        {
            Conexion = nuevaConexion;
        }

    }
}
