
using System;
using Arreglos_Biblioteca; // El 'using' debe ir arriba de todo

namespace MiArreglo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Operaciones de pila");
            Console.WriteLine("Arreglo de linea");

            // 1. Declarar la variable (miArreglo) e instanciarla
            Arreglo1 miArreglo = new Arreglo1(100);

            // 2. Usar la variable 'miArreglo' para invocar sus métodos
            miArreglo.Llenar(1, 20);

            Console.WriteLine("Arreglo desordenado\n");
            Console.WriteLine(miArreglo);

            Console.WriteLine("Arreglo ordenado ascendente\n");
            miArreglo.Ordenar();
            Console.WriteLine(miArreglo);

            Console.WriteLine("\nArreglo\n");
            miArreglo.Llenar();
            Console.WriteLine("\nPares\n");
            var verPares = miArreglo.ObtenerPares();
            verPares.Ordenar(false);

            Console.WriteLine("\nPares\n");
            var VerPrimos = miArreglo.ObtenerPrimos();
            Console.WriteLine(VerPrimos); 
            Console.WriteLine("\nPares Ordenados\n");
            VerPrimos.Ordenar();
            Console.WriteLine(VerPrimos);
           

      
        



        }
    }
}