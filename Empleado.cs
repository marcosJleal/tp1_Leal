using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_Leal
{
    public class Empleado:Persona
    {
        public int Legajo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Cargo { get; set; }
    }
}
