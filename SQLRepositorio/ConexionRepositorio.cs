using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SQLRepositorio
{
    public class ConexionRepositorio
    {
        public static string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["cnControl"].ToString();
        }
    }
}
