using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            autorNuevo.FechaNacimiento = autorAgregar.FechaNacimiento;
            autorNuevo.Biografia = autorAgregar.Biografia;
            autorNuevo.CantidadLibrosEscritos = autorAgregar.CantidadLibrosEscritos;
            autorNuevo.PersonaAutor = autorAgregar.PersonaAutor;
            autorNuevo.Libros = autorAgregar.Libros;

            _autorRepository.Create(autorNuevo);
            _autorRepository.Save();
        }

        public void BajaAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !DocumentoEsValido(documento))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Autor? autorEliminar = _autorRepository.FindByCondition(p => p.PersonaAutor.Documento == documento).FirstOrDefault();

            if (autorEliminar == null)
            {
                throw new InvalidOperationException("La persona que se desea eliminar no existe.");
            }

            _autorRepository.Delete(autorEliminar);
            _autorRepository.Save();
        }

        public void ActualizacionAutor(string documento, Autor autorActualizar)
        {
            if (string.IsNullOrEmpty(documento) || !DocumentoEsValido(documento))
            {
                throw new ArgumentException("El documento ingresado no es valido.");
            }

            Autor? autor = _autorRepository.FindByCondition(p => p.PersonaAutor.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se encontro una persona con ese documento.");
            }

            autor.Biografia = autorActualizar.Biografia;
            autor.CantidadLibrosEscritos = autorActualizar.CantidadLibrosEscritos;
            autor.Libros = autorActualizar.Libros;

            _autorRepository.Update(autor);
            _autorRepository.Save();
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
