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
        void AltaAutor(string nombre, string apellido, string nacionalidad, string email, string fechaNacimiento, string telefono, string biografia);
        void BajaAutor(string documento);
        void ActualizacionAutor(string idAutor, string nombre, string apellido, string nacionalidad, string email, string fechaNacimiento, string telefono, string biografia);
        List<Autor> ObtenerAutores();
        List<dynamic> ObtenerAutoresParaListado();
    }
}
