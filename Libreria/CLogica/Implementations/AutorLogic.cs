using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;

        public AutorLogic(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public void AltaAutor(Autor autorAgregar)
        {
            Autor autorNuevo = new Autor();

            List<string> camposErroneos = new List<string>();

            if (autorAgregar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ningun autor.");
            }

            if (autorAgregar.PersonaAutor == null)
            {
                throw new ArgumentNullException("Se le debe asignar una persona al autor.");
            }
        }
        public void BajaAutor(string documento)
        {

        }

        public void ActualizacionAutor(string documento, Autor autorActualizar)
        {

        }

        #region validaciones
        #endregion
    }
}
