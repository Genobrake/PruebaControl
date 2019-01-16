using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ContratoRepositorio;
using SQLRepositorio;

namespace Fachada
{
    public class EspecieFachada : IDisposable
    {
        public bool AgregarEspecie(Especie especie)
        {
            IEspecieRepositorio instancia = new EspecieRepositorio();
            return instancia.AgregarEspecie(especie) > 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
