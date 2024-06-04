using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Libreria
{
    public class Libro
    {
        public int id { get; set; }
        public string isbn { get; set; }
        public string descripcion { get; set; }
        public Autor autorLibro { get; set; }
    }
}
