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
    public class LibroLogic : ILibroLogic
    {
        private ILibroRepository _libroRepository;

        public LibroLogic(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        public void AltaLibro(Libro libroAgregar)
        {
            Libro libroNuevo = new Libro();

            List<string> camposErroneos = new List<string>();

            if (libroAgregar == null)
            {
                throw new ArgumentNullException("No se ha ingresado ningun libro.");
            }

            if (!ISBNEsValido(libroAgregar.ISBN) || _libroRepository.FindByCondition(p => p.ISBN == libroAgregar.ISBN).Count() != 0)
            {
                camposErroneos.Add("ISBN");
            }

            if (libroAgregar.Titulo == null)
            {
                throw new ArgumentNullException("titulo");
            }

            if (libroAgregar.Descripcion == null)
            {
                throw new ArgumentNullException("descripcion");
            }

            if (libroAgregar.Autores == null)
            {
                throw new ArgumentNullException("autor");
            }

            if (libroAgregar.Generos == null)
            {
                throw new ArgumentNullException("genero");
            }

            if (libroAgregar.Editorial == null)
            {
                throw new ArgumentNullException("editorial");
            }

            if (libroAgregar.PrecioVenta <= 0)
            {
                throw new ArgumentNullException("precio");
            }

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son invalidos: ", string.Join(", ", camposErroneos));
            }

            libroNuevo.ISBN = libroAgregar.ISBN;
            libroNuevo.Titulo = libroAgregar.Titulo;
            libroNuevo.Descripcion = libroAgregar.Descripcion;
            libroNuevo.Autores = libroAgregar.Autores;
            libroNuevo.Generos = libroAgregar.Generos;
            libroNuevo.Editorial = libroAgregar.Editorial;
            libroNuevo.PrecioVenta = libroAgregar.PrecioVenta;

            _libroRepository.Create(libroNuevo);
            _libroRepository.Save();
    }

        #region validaciones
        private bool ISBNEsValido(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return true;
            }

            var regex = new Regex(@"^(?:\d{1,5}-\d{1,7}-\d{1,7}-[\dX]|\d{3}-\d{1,5}-\d{1,7}-\d{1,7}-\d)$");
            return regex.IsMatch(isbn);
        }
        #endregion
    }
}
