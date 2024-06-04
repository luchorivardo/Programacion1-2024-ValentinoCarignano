using Logica.Libreria;

namespace Logica
{
    public class Principal
    {
        List<Libro> listaLibros = new List<Libro>();

        public void AgregarLibroManera1(Libro libro)
        {
            listaLibros.Add(libro);
        }
        public void AgregarLibroManera2(Libro libro)
        {
            Libro libroAgregado = new Libro();

            libroAgregado.id = libro.id;
            libroAgregado.isbn = libro.isbn;
            libroAgregado.descripcion = libro.descripcion;

            libroAgregado.autorLibro.id = libro.autorLibro.id;
            libroAgregado.autorLibro.nombre = libro.autorLibro.nombre;
            libroAgregado.autorLibro.fechaNacimiento = libro.autorLibro.fechaNacimiento;

            listaLibros.Add(libroAgregado);
        }
        public void AgregarLibroManera3(int id, string isbn, string descripcion, int idAutor, string nombreAutor, DateTime fechaNacimientoAutor)
        {
            Libro libroAgregado = new Libro();

            libroAgregado.id = id;
            libroAgregado.isbn = isbn;
            libroAgregado.descripcion = descripcion;

            libroAgregado.autorLibro.id = idAutor;
            libroAgregado.autorLibro.nombre = nombreAutor;
            libroAgregado.autorLibro.fechaNacimiento = fechaNacimientoAutor;

            listaLibros.Add(libroAgregado);
        }
    }
}