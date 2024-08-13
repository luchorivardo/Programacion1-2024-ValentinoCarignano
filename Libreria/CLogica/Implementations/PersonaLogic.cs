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

        public async Task<List<Persona>> GetAll()
        {
            return await _personaRepository.GetAll();
        }

        public void AltaPersona(Persona personaAgregar)
        {
            Persona personaNueva = new Persona();

            List<string> camposErroneos = new List<string>();

            if (personaAgregar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ninguna persona.");
            }

            if (!DocumentoEsValido(personaAgregar.Documento) || _personaRepository.FindByCondition(p => p.Documento == personaAgregar.Documento).Count() != 0)
            {
                camposErroneos.Add("documento");
            }

            if (!NombreApellidoEsValido(personaAgregar.Nombre))
            {
                camposErroneos.Add("nombre");
            }

            if (!NombreApellidoEsValido(personaAgregar.Apellido))
            {
                camposErroneos.Add("apellido");
            }

            if (!TelefonoEsValido(personaAgregar.Telefono))
            {
                camposErroneos.Add("telefono");
            }

            if (personaAgregar.Autor != null)
            {
                personaNueva.Autor = personaAgregar.Autor;
            }
            else if (personaAgregar.Cliente != null)
            {
                personaNueva.Cliente = personaAgregar.Cliente;
            }
            else if (personaAgregar.Empleado != null)
            {
                personaNueva.Empleado = personaAgregar.Empleado;
            }
            else
            {
                camposErroneos.Add("tipo");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            personaNueva.Nombre = personaAgregar.Nombre;
            personaNueva.Apellido = personaAgregar.Apellido;
            personaNueva.Documento = personaAgregar.Documento;
            personaNueva.Telefono = personaAgregar.Telefono;

            _personaRepository.Create(personaNueva);
            _personaRepository.Save();
        }

        public void BajaPersona(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !DocumentoEsValido(documento))
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

        public void ActualizacionPersona(string documento, Persona personaActualizar)
        {
            if (string.IsNullOrEmpty(documento) || !DocumentoEsValido(documento))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Persona? personaExistente = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();
            
            if (personaExistente == null)
            {
                throw new ArgumentNullException("No se encontro una persona con ese documento.");
            }

            List<string> camposErroneos = new List<string>();

            if (!DocumentoEsValido(personaActualizar.Documento))
            {
                camposErroneos.Add("documento");
            }

            if (!NombreApellidoEsValido(personaActualizar.Nombre))
            {
                camposErroneos.Add("nombre");
            }

            if (!NombreApellidoEsValido(personaActualizar.Apellido))
            {
                camposErroneos.Add("apellido");
            }

            if (!TelefonoEsValido(personaActualizar.Telefono))
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
        }

        #region validaciones
        private bool DocumentoEsValido(string documento)
        {
            if (string.IsNullOrWhiteSpace(documento) || documento.Length < 8)
            {
                return false;
            }

            foreach (char c in documento)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }     

            return true;
        }
        private bool NombreApellidoEsValido(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }

            texto = texto.Trim();

            if (texto.Contains("  "))
            {
                return false;
            }

            if (texto.Length < 3 || texto.Length > 20)
            {
                return false;
            }

            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }

            return true;
        }
        private bool TelefonoEsValido(string telefono)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                return true;
            }

            var regex = new Regex(@"^\+\d{1,4}\s?\d{1,5}\s?\d{6,}$");
            return regex.IsMatch(telefono);
        }
        #endregion
    }
}