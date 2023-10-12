using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Celular_Nuevo> listCelu = new List<Celular_Nuevo>();
            listCelu.Add(new Celular_Nuevo 
            {
                Marca="Samsung",
                Modelo=2012,
                SO="Android",
                Ram=4,
                Almacenamiento=128,
                Fecha_ingreso=DateTime.Parse("02/12/2005"),
                Precio=2600
            });

            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Sony",
                Modelo = 2012,
                SO = "Android",
                Ram = 3,
                Almacenamiento = 64,
                Fecha_ingreso = DateTime.Parse("02/12/2016"),
                Precio = 2000
            });
            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Apple",
                Modelo = 2012,
                SO = "IOS",
                Ram = 4,
                Almacenamiento = 128,
                Fecha_ingreso = DateTime.Parse("02/12/2005"),
                Precio = 2600
            });
            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Samsung",
                Modelo = 2010,
                SO = "Android",
                Ram = 8,
                Almacenamiento = 128,
                Fecha_ingreso = DateTime.Parse("02/12/2022"),
                Precio = 3000
            });
            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Xiaomi",
                Modelo = 2005,
                SO = "Android",
                Ram = 4,
                Almacenamiento = 128,
                Fecha_ingreso = DateTime.Parse("02/12/2005"),
                Precio = 2600
            });
            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Poco",
                Modelo = 2011,
                SO = "Android",
                Ram = 4,
                Almacenamiento = 128,
                Fecha_ingreso = DateTime.Parse("02/12/2022"),
                Precio = 2300
            });
            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Apple",
                Modelo = 2014,
                SO = "IOS",
                Ram = 8,
                Almacenamiento = 254,
                Fecha_ingreso = DateTime.Parse("02/12/2021"),
                Precio = 4600
            });
            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Apple",
                Modelo = 2005,
                SO = "IOS",
                Ram = 4,
                Almacenamiento = 128,
                Fecha_ingreso = DateTime.Parse("02/12/2018"),
                Precio = 1300
            });

            listCelu.Add(new Celular_Nuevo
            {
                Marca = "sony",
                Modelo = 2005,
                SO = "Android",
                Ram = 4,
                Almacenamiento = 64,
                Fecha_ingreso = DateTime.Parse("02/12/2021"),
                Precio = 1300
            });

            listCelu.Add(new Celular_Nuevo
            {
                Marca = "Samsung",
                Modelo = 2005,
                SO = "Android",
                Ram = 8,
                Almacenamiento = 128,
                Fecha_ingreso = DateTime.Parse("02/12/2018"),
                Precio = 1200
            });
            int i=1;
            foreach (var item in listCelu) {
                Console.WriteLine("Celular " + i);
                item.Mostrar();
                Console.WriteLine("-----------------------------------------------------------------");
                i++;
            }

            double Prom_Celular = listCelu.Average(x => x.Precio);
            Console.WriteLine("El promedio de los precios es: "+Prom_Celular);
            var Cel_Marca = listCelu.Where(x => x.Marca=="Samsung");
            Console.WriteLine("los celulares con marca samsung son: ");
            foreach (var item in Cel_Marca)
            {
                Console.WriteLine(item.Marca+" "+item.Modelo);
            }

            Celular_RSA(listCelu);
            void Celular_RSA(List<Celular_Nuevo> listcelu)
            {
                var celRSA = from Celular in listCelu
                             where Celular.Ram == 8
                             where Celular.SO== "Android"
                             where Celular.Almacenamiento == 128
                    select Celular;

                Console.WriteLine("los celulares con ram 8, SO Android y Almacenamiento de 128 son: ");
                foreach (var item in celRSA)
                {
                    Console.WriteLine(item.Marca+" "+item.Modelo);
                };


            }


            Celular_Ingreso(listCelu);
            void Celular_Ingreso(List<Celular_Nuevo> listcelu)
            { 
            var ingreso = from celular in listcelu
                          where celular.Fecha_ingreso.Year == 2005
                          select celular;

                Console.WriteLine("los celulares que ingresaron el año 2005 son: ");
                foreach (var item in ingreso)
                {

                    Console.WriteLine(item.Marca + " " + item.Modelo);
                }
            }
            Console.WriteLine("------------Exprecion lambda-----------------");
            var marca = listCelu.Where(x=> x.Marca=="Apple" );
            foreach (var item in marca)
            {
                Console.WriteLine(item.Marca+" modelo"+item.Modelo+" precio "+item.Precio);
            }
            Console.WriteLine("----------------Exprecion LinQ------------");
            marca1(listCelu);
            
            void marca1(List<Celular_Nuevo> listcelu)
            { 
            var listcelu1 = from Celular in listCelu
                           where Celular.Marca == "Apple"
                           select Celular;
                foreach (var item in listcelu1)
                {
                    Console.WriteLine(item.Marca+" modelo"+item.Modelo+" precio "+item.Precio);
                }
            }
            Console.ReadKey();
        }
    }
}
