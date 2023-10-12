using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    public class Celular_Nuevo:Celular
    {
        public DateTime Fecha_ingreso { get; set; }
        public int Precio { get; set; }
         public override void Mostrar() {
            base.Mostrar();
            Console.WriteLine("\n Fecha de ingreso: " + Fecha_ingreso+ "\n Su precio es: " + Precio);
            
        }
          
    }
    
}
