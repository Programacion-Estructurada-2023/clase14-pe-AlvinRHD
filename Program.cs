//CLASE
/*using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar una variable int para opciones

            int opciones;

            do
            {
                Console.WriteLine("\n\nMenú:");
                Console.WriteLine("1.Programa que muestre los numeros de n al 1 de manera descendente");
                Console.WriteLine("2.Programa que muestre los numeros de 1 a 5 con while");
                Console.WriteLine("3.Programa que muestre el umero minimo de una lista");
                Console.WriteLine("4.Salir ");
                Console.WriteLine("Seleccione una opcion (1-4): ");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese un numero (n): ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            if (n >= 1)
                            {
                                for (int i =n; i >= 1; i--)
                                {
                                    Console.WriteLine($"Numero > {i}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresar un numero mayor a 1 ");
                            }

                            break;
                        case 2:

                            int contador = 1;

                            while (contador <=5)
                            {
                                Console.WriteLine($"Numero >>{contador}");
                                contador++;
                            }

                            break;
                        case 3:
                            List<int> numeros = new List<int> { 24, 15, 45, 35, 14, 10 };

                            int minimo = numeros[0]; //Inicializar con valor del  indice 0


                            foreach (int numero1 in numeros)
                            {

                                if (numero1 < minimo)
                                {
                                    minimo = numero1; //Actualizar el valor minimo
                                }
                            }

                            Console.WriteLine("El numero mas pequeño en la lista es > " + minimo);

                            break;
                        case 4:

                            break;
                        default:
                            Console.WriteLine("Opcion no valida. Porfavor, seleccione una opcion valida");
                            break;
                    }

                }
                else
                {

                    Console.WriteLine("\nEntrada no valida. Debe ingresar un numero (1-4).");
                }

            } while (opciones != 4);

        }
    }
}*/



//EJERCICIOS GUIA
using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar una variable int para opciones

            int opciones;

            do
            {
                Console.WriteLine("\n\nMenú:");
                Console.WriteLine("1.Función que suma los numeros pares hastael 75");
                Console.WriteLine("2.Recorrido de una lista de 9 números enteros y encuentra el numero mas grande");
                Console.WriteLine("3.Representación de una tabla de multiplicar de un numero n,al valor de “n x i” le sume 2.");
                Console.WriteLine("4.Salir ");
                Console.WriteLine("Seleccione una opcion (1-4): ");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            int suma = 0;
                            for (int i = 3; i <= 75; i += 3)
                            {
                                suma += i;
                            }

                            Console.WriteLine($"Los numeros sumados pares hasta 75 son = {suma}");

                            break;
                        case 2:
                            List<int> numgr = new List<int> { 5, 10, 15, 20, 25, 1, 3, 6, 50 };

                            int max = numgr[0];

                            foreach (int numlist in numgr)
                            {
                                if (numlist > max)
                                {
                                    max = numlist;
                                }
                            }

                            Console.WriteLine("El numero mas grande es > " + max);


                            break;
                        case 3:
                            Console.WriteLine("\nIngrese numero para iniciar tabla de multiplicar");
                            int num = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= 12; i++)
                            {

                                int multiplicar = num * i;

                                Console.WriteLine($"{num} x {i} = {multiplicar}");

                                int multiplicar2 = num * i + 2;

                                Console.WriteLine($"{num} x {i} = {multiplicar2}");


                            }


                            break;
                        case 4:

                            break;
                        default:
                            Console.WriteLine("Opcion no valida. Porfavor, seleccione una opcion valida");
                            break;
                    }

                }
                else
                {

                    Console.WriteLine("\nEntrada no valida. Debe ingresar un numero (1-4).");
                }

            } while (opciones != 4);

        }
    }
}

