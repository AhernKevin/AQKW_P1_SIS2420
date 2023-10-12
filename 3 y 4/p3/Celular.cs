using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string SO { get; set; }
        public int Ram { get; set; }
        public int Almacenamiento { get; set; }

        public virtual void Mostrar() {
            Console.WriteLine("\n la marca es: " + Marca + "\n el modelo es: " + Modelo+ "\n tiene SO: " + SO+" \n Con Ram de: "+Ram+ "\n Con almacenamiento: " + Almacenamiento);
        }
    }
}
