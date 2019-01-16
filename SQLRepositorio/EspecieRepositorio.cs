using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using ContratoRepositorio;
using Dominio;

namespace SQLRepositorio
{
    public class EspecieRepositorio : IEspecieRepositorio
    {
        public int AgregarEspecie(Especie especie)
        {
            int valor = 0;
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.getConexion()))
            {
                conexion.Open();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@intCodigo", especie.Codigo);
                parametros.Add("@nvcNombre", especie.Nombre);
                parametros.Add("@intCodCtaCtb", especie.CodCtaCtb);
                parametros.Add("@intEstado", especie.Estado);
                conexion.Execute("sp_ActualizarEspecie", param: parametros, commandType: CommandType.StoredProcedure);
                valor = 1;
                return valor;
            }
        }
    }
}
