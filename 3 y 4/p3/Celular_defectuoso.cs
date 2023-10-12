using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    public class Celular_defectuoso:Celular
    {
        public DateTime Fecha_Defecto { get; set; }
        public string Motivo { get; set; }
        public override void Mostrar()
        {
            Console.WriteLine("\n Fecha de defecto: " + Fecha_Defecto + "\n el motivo es: " + Motivo);
        }
    }
}
