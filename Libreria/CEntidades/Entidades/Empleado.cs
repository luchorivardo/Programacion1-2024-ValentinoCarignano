using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Empleado : Persona
    {
        public DateTime Antiguedad { get; set; }
        public string Cargo { get; set; }
        public double Sueldo { get; set; }
    }
}
