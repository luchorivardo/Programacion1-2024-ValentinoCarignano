using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ILibroLogic
    {
        void AltaLibro(Libro libroAgregar);
        void BajaLibro(string isbn);
        void ActualizacionLibro(string isbn, Libro libroActualizar);
    }
}
