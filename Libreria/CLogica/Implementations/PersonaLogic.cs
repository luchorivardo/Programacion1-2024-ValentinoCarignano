using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System.Linq;
using System.Text.RegularExpressions;

namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;

        public PersonaLogic(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {
            return await _personaRepository.GetAll();
        }

        public Persona AltaPersona(Persona personaAgregar)
        {
            Persona personaNueva = new Persona();

            List<string> camposErroneos = new List<string>();

            if (personaAgregar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ninguna persona.");
            }

            if (!ValidacionesLogic.DocumentoEsValido(personaAgregar.Documento) || _personaRepository.FindByCondition(p => p.Documento == personaAgregar.Documento).Count() != 0)
            {
                if(personaAgregar.Documento != null)
                {
                    camposErroneos.Add("documento");
                }
            }

            if (!ValidacionesLogic.NombreApellidoEsValido(personaAgregar.Nombre))
            {
                camposErroneos.Add("nombre");
            }

            if (!ValidacionesLogic.NombreApellidoEsValido(personaAgregar.Apellido))
            {
                camposErroneos.Add("apellido");
            }

            if (!ValidacionesLogic.TelefonoEsValido(personaAgregar.Telefono))
            {
                camposErroneos.Add("telefono");
            }

            if (string.IsNullOrWhiteSpace(personaAgregar.Email))
            {
                camposErroneos.Add("email");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            personaNueva.TipoDocumento = personaAgregar.TipoDocumento;
            personaNueva.Documento = personaAgregar.Documento;
            personaNueva.Nombre = personaAgregar.Nombre;
            personaNueva.Apellido = personaAgregar.Apellido;
            personaNueva.Nacionalidad = personaAgregar.Nacionalidad;
            personaNueva.Telefono = personaAgregar.Telefono;
            personaNueva.Email = personaAgregar.Email;
            
            _personaRepository.Create(personaNueva);
            _personaRepository.Save();

            return personaNueva;
        }

        public void BajaPersona(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !ValidacionesLogic.DocumentoEsValido(documento))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Persona? personaEliminar = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (personaEliminar == null)
            {
                throw new InvalidOperationException("La persona que se desea eliminar no existe.");
            }

            _personaRepository.Delete(personaEliminar);
            _personaRepository.Save();
        }

        public Persona ActualizacionPersona(Persona personaActualizar)
        {
            //TODO: terminar metodo actualizar persona.

            if (string.IsNullOrEmpty(documento) || !ValidacionesLogic.DocumentoEsValido(documento))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Persona? personaExistente = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            
            if (personaExistente == null)
            {
                throw new ArgumentNullException("No se encontro una persona con ese documento.");
            }

            List<string> camposErroneos = new List<string>();

            if (!ValidacionesLogic.DocumentoEsValido(personaActualizar.Documento))
            {
                camposErroneos.Add("documento");
            }

            if (!ValidacionesLogic.NombreApellidoEsValido(personaActualizar.Nombre))
            {
                camposErroneos.Add("nombre");
            }

            if (!ValidacionesLogic.NombreApellidoEsValido(personaActualizar.Apellido))
            {
                camposErroneos.Add("apellido");
            }

            if (!ValidacionesLogic.TelefonoEsValido(personaActualizar.Telefono))
            {
                camposErroneos.Add("telefono");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            personaExistente.Nombre = personaActualizar.Nombre;
            personaExistente.Apellido = personaActualizar.Apellido;
            personaExistente.Documento = personaActualizar.Documento;
            personaExistente.Telefono = personaActualizar.Telefono;

            _personaRepository.Update(personaExistente);
            _personaRepository.Save();

            return Persona personaExistente;
        }
    }
}