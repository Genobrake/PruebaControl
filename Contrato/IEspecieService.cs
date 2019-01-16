using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.ServiceModel;

namespace Contrato
{
    [ServiceContract]
    public interface IEspecieService
    {
        [OperationContract]
        bool InsertarEspecie(Especie especie);
    }
}
