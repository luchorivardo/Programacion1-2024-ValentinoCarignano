using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        void AltaAutor(Autor autorAgregar);
        void BajaAutor(string documento);
        void ActualizacionAutor(string documento, Autor autorActualizar);
    }
}
