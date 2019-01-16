using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Dominio;
using Contrato;
using Fachada;

namespace Implementacion
{
    public class EspecieService : IEspecieService
    {
        public bool InsertarEspecie(Especie especie)
        {
            try
            {
                using (EspecieFachada instancia = new EspecieFachada())
                {
                    return instancia.AgregarEspecie(especie);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<Error>(new Error() { Codigo = "5014", Descripcion = "Error al insertar persona", Mensaje = ex.Message });
            }
        }
    }
}
