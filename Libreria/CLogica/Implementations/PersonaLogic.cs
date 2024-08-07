using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System.Text.RegularExpressions;

namespace CLogica.Implementations
{
    public class PersonaLogic : IPersonaLogic
    {
        private IPersonaRepository _personaRepository;

        public PersonaLogic(IPersonaRepository exampleRepository)
        {
            _personaRepository = exampleRepository;
        }

        public void AltaPersona(Persona persona)
        {
            Persona personaNueva = new Persona();

            List<string> camposErroneos = new List<string>();

            if (persona == null)
            {
                throw new ArgumentNullException("No se ha ingresado ninguna persona.");
            }

            if (_personaRepository.FindByCondition(p => p.Documento == persona.Documento) != null)
            {
                throw new InvalidOperationException("El DNI no puede coincidir con uno ya ingresado.");
            }

            if (!DocumentoEsValido(persona.Documento))
            {
                camposErroneos.Add("documento");
            }

            if (!NombreApellidoEsValido(persona.Nombre))
            {
                camposErroneos.Add("nombre");
            }

            if (!NombreApellidoEsValido(persona.Apellido))
            {
                camposErroneos.Add("apellido");
            }

            if (!TelefonoEsValido(persona.Telefono))
            {
                camposErroneos.Add("telefono");
            }

            if (persona.Autor != null)
            {
                personaNueva.Autor = persona.Autor;
            }
            else if (persona.Cliente != null)
            {
                personaNueva.Cliente = persona.Cliente;
            }
            else if (persona.Empleado != null)
            {
                personaNueva.Empleado = persona.Empleado;
            }
            else
            {
                camposErroneos.Add("tipo");
            }

            //TODO: hacer metodo para mostrar campos erroneos


            personaNueva = persona;
            _personaRepository.Create(personaNueva);
            _personaRepository.Save();
        }

        public void BajaPersona(string documento)
        {
            if (documento == null)
            {
                throw new ArgumentNullException("No se ha seleccionado ninguna persona.");
            }

            Persona? personaEliminada = _personaRepository.FindByCondition(p => p.Documento == documento).FirstOrDefault();

            if (personaEliminada == null)
            {
                throw new InvalidOperationException("La persona que se desea eliminar no existe.");
            }

            _personaRepository.Delete(personaEliminada);
            _personaRepository.Save();
        }

        public void ActualizacionPersona(string documento, string nombre, string apellido)
        {

        }

        //Metodos de validacion
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
    }
}