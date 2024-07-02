namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }

        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public int PrecioVenta { get; set; }

        public ICollection<Autor> Autores { get; set; }
        public Editorial EditorialLibro { get; set; }
    }
}
