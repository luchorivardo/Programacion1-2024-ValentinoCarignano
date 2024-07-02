using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Autor : Persona
    {
        public DateTime FechaNacimientoAutor { get; set; }
        public string BiografiaAutor { get; set; }
        public string NacionalidadAutor { get; set; }
    }
}
