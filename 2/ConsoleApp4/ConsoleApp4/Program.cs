using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
    
        
            public List<int> Multiplos_2(List<int> lista)
            {
                List<int> multi = new List<int>();

                foreach (int i in lista)
                {
                    if (i % 2 == 0)
                        if (!multi.Contains(i)) multi.Add(i);
                }
                multi.Sort();
                return multi;
            }

            internal List<int> Multiplos_5(List<int> lista)
            {
                List<int> multi = new List<int>();

                foreach (int i in lista)
                {
                    if (i % 5 == 0)
                        if (!multi.Contains(i)) multi.Add(i);
                }
                multi.Sort();
                return multi;
            }

            internal List<int> Perfectos(List<int> lista)
            {
                List<int> perf = new List<int>();

                foreach (int i in lista)
                {
                    if (Num_Perfecto(i))
                        if (!perf.Contains(i)) perf.Add(i);
                }
                perf.Sort();
                return perf;
            }

            public bool Num_Perfecto(int num)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum += i;
                }

                if (sum == num) return true;
                return false;
            }

            internal List<int> Primos(List<int> lista)
            {
                List<int> primos = new List<int>();

                foreach (int i in lista)
                {
                    if (Num_Primo(i, i - 1))
                        if (!primos.Contains(i)) primos.Add(i);
                }
                primos.Sort();
                return primos;
            }

            public bool Num_Primo(int num, int i)
            {
                if (i == 1) return true;
                else if (num % i == 0) return false;
                else return Num_Primo(num, i - 1);
            }


            public void Mostrar(List<int> lista)
            {
                foreach (int i in lista)
                {
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }



            static void Main(string[] args)
            {
                List<int> numeros = new List<int>();
                int n;

                Console.Write("¿Cuántos numeros deseas Añadir PRO :V ?:  ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Ingresar" + n + " numeros");
                    for (int i = 0; i < n; i++)
                    {
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            numeros.Add(numero);
                        }
                        else
                        {
                            Console.WriteLine("Solo numeros enteros cabezon ");
                            i--;
                        }
                    }

                    Program lista = new Program();

                    //Listas
                    List<int> MultiplosDe2 = lista.Multiplos_2(numeros);
                    List<int> Primos = lista.Primos(numeros);
                    List<int> MultiplosDe5 = lista.Multiplos_5(numeros);
                    List<int> Perfectos = lista.Perfectos(numeros);
                    Console.WriteLine();
                    Console.Write("Lista 1: ");
                    lista.Mostrar(MultiplosDe2);
                    Console.Write("Lista 2: ");
                    lista.Mostrar(Primos);
                    Console.Write("Lista 3: ");
                    lista.Mostrar(MultiplosDe5);
                    Console.Write("Lista 4: ");
                    lista.Mostrar(Perfectos);

                }
                else
                {
                    Console.WriteLine("numero invalido");
                }









                Console.ReadKey();

            }
        
    }
}
