
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


            miArreglo.Agregar(-2);
            miArreglo.Agregar(8);



        }
    }
}