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
        void AltaAutor(string nombre, string apellido, string nacionalidad, string telefono, string fechaNacimiento, string biografia);
        void BajaAutor(string documento);
        void ActualizacionAutor(string documento, Autor autorActualizar);
        List<Autor> ObtenerAutores();
        List<dynamic> ObtenerAutoresParaListado();
    }
}
