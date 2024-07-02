using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class GeneroLibro
    {
        public int IdGeneroLibro { get; set; }

        public Libro LibroGeneroLibro { get; set; }
        public Genero GeneroGeneroLibro { get; set; }
    }
}
