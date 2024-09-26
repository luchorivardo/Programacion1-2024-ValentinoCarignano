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
    public class EditorialLogic : IEditorialLogic
    {
        private IEditorialRepository _editorialRepository;
        public EditorialLogic(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }

        public void AltaEditorial(string nombre, string contacto, string direccion)
        {

            try
            {
                Editorial nuevaEditorial = new Editorial()
                {
                    Nombre = nombre,
                    Direccion = direccion,
                    Contacto = contacto
                };

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(nombre))
                {
                    camposErroneos.Add("Nombre");
                }
                if (string.IsNullOrEmpty(direccion))
                {
                    camposErroneos.Add("Direccion");
                }
                if (string.IsNullOrEmpty(contacto) ||!ValidacionesLogic.TelefonoEsValido(contacto))
                {
                    camposErroneos.Add("Contacto");
                }
                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: "+ string.Join(", ", camposErroneos));
                }
                _editorialRepository.Create(nuevaEditorial);
                _editorialRepository.Save();
         
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
