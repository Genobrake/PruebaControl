using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace ContratoRepositorio
{
    public interface IEspecieRepositorio
    {
        int AgregarEspecie(Especie datosespecie);
    }
}
