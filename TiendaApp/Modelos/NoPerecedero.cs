using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Modelos;

namespace TiendaApp.Modelos.Productos
{
    public class NoPerecedero : Producto{

        public DateTime FechaDeFabricacion { get; set; }

        public int Lote { get; set; }

    }
}