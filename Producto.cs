using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_Leal
{
    public class Producto
    {
        public int Id { get; set; }
        public Marca Marca { get; set; }
        public string Descripcion { get; set; }
        public Contenedor Contenedor { get; set; }

    }
}
