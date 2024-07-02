namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }

        public string ISBN { get; set; }
        public string TituloLibro { get; set; }
        public int AnioPublicacionLibro { get; set; }
        public string DescripcionLibro { get; set; }

        public Editorial IdEditorial { get; set; }
    }
}
