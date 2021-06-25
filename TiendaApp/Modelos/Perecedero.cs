using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaApp.Modelos;

namespace TiendaApp.Modelos.Productos
{
    public class Perecedero : Producto{
        
        public Perecedero(){
            
        }

        public Perecedero(DateTime vencimiento)
        {

            this.FechaDeVencimiento = vencimiento;

        }
        
        public DateTime FechaDeVencimiento { get; set; }
    }
}