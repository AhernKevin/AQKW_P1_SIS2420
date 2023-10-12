using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Class1
    {
        
            public int numero { get; set; }

            public void Numero()
            {
                bool esNum = false;
                while (!esNum)
                {
                    Console.Write("Porfavor ingreso solo enteros  ");
                    string num = Console.ReadLine();
                    try
                    {
                        numero = int.Parse(num);
                        esNum = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Solo enteros cabezon");
                    }
                }
            }

            public void Literal()
            {

                if (numero > 9999 || numero < 0)
                {
                    Console.WriteLine("Solo en el Rango 9999 ");

                }
                else
                {
                    int[] numerales = new int[9];


                    int i = 0;
                    while (numero > 0)
                    {
                        numerales[i] = numero % 10;
                        numero /= 10;
                        i++;
                    }
                    Literales(numerales);
                }
            }

            public void Literales(int[] numerales)
            {


                switch (numerales[3])
                {
                    case 1:
                        if (numerales[2] == 0 && numerales[1] == 0 && numerales[0] == 0)
                            Console.Write("Mil.");
                        else Console.Write(numerales[4] == 1 ? "" : "mil ");
                        break;
                    case 2: Console.Write(numerales[4] == 1 ? "" : "dos mil "); break;
                    case 3: Console.Write(numerales[4] == 1 ? "" : "tres mil "); break;
                    case 4: Console.Write(numerales[4] == 1 ? "" : "cuatro mil "); break;
                    case 5: Console.Write(numerales[4] == 1 ? "" : "cinco mil "); break;
                    case 6: Console.Write("seis mil "); break;
                    case 7: Console.Write("siete mil "); break;
                    case 8: Console.Write("ocho mil "); break;
                    case 9: Console.Write("nueve mil "); break;
                }


                switch (numerales[2])
                {
                    case 1: Console.Write(numerales[1] == 0 && numerales[0] == 0 ? "Cien." : "ciento "); break;
                    case 2: Console.Write("doscientos "); break;
                    case 3: Console.Write("trescientos "); break;
                    case 4: Console.Write("cuatrocientos "); break;
                    case 5: Console.Write("quinientos "); break;
                    case 6: Console.Write("seiscientos "); break;
                    case 7: Console.Write("setecientos "); break;
                    case 8: Console.Write("ochocientos "); break;
                    case 9: Console.Write("novecienttos "); break;
                }


                switch (numerales[1])
                {
                    case 1:
                        Console.Write(numerales[0] == 0 ? "Diez." : numerales[0] > 5 ? "dieci" : "");
                        switch (numerales[0])
                        {
                            case 1: Console.Write("once."); break;
                            case 2: Console.Write("doce."); break;
                            case 3: Console.Write("trece."); break;
                            case 4: Console.Write("catorce."); break;
                            case 5: Console.Write("quince."); break;
                        }
                        break;
                    case 2: Console.Write("veinti"); break;
                    case 3: Console.Write("treinta y "); break;
                    case 4: Console.Write("cuarenta y "); break;
                    case 5: Console.Write("cincuenta y "); break;
                    case 6: Console.Write("sesenta y "); break;
                    case 7: Console.Write("setenta y "); break;
                    case 8: Console.Write("ochenta y "); break;
                    case 9: Console.Write("noventa y "); break;
                }


                switch (numerales[0])
                {
                    case 0:
                        if (numerales[1] == 0 && numerales[2] == 0 &&
                            numerales[3] == 0 && numerales[4] == 0 &&
                            numerales[5] == 0 && numerales[6] == 0 &&
                            numerales[7] == 0 && numerales[8] == 0)
                            Console.Write("Cero.");
                        else switch (numerales[1])
                            {
                                case 2: Console.Write("Veinte."); break;
                                case 3: Console.Write("Treinta."); break;
                                case 4: Console.Write("Cuarenta."); break;
                                case 5: Console.Write("Cincuenta."); break;
                                case 6: Console.Write("Sesenta."); break;
                                case 7: Console.Write("Setenta."); break;
                                case 8: Console.Write("Ochenta."); break;
                                case 9: Console.Write("Noventa."); break;
                            }
                        break;
                    case 1: Console.Write(numerales[1] == 1 ? "" : "uno"); break;
                    case 2: Console.Write(numerales[1] == 1 ? "" : "dos"); break;
                    case 3: Console.Write(numerales[1] == 1 ? "" : "tres"); break;
                    case 4: Console.Write(numerales[1] == 1 ? "" : "cuatro"); break;
                    case 5: Console.Write(numerales[1] == 1 ? "" : "cinco"); break;
                    case 6: Console.Write("seis"); break;
                    case 7: Console.Write("siete"); break;
                    case 8: Console.Write("ocho"); break;
                    case 9: Console.Write("nueve"); break;
                }

            }


        
    }
}
