using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_Leal
{
    public class Pasillo

    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public char Lado { get; set; }
        public Contenedor Contenedor { get; set; }
        public Cliente Cliente { get; set; }
    }
}
