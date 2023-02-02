using System;
// Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.
namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _numeros = new int[10];
            int _contador = 0;
            int _numero;

            Console.WriteLine("Ingrese 10 números:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                _numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese un número: ");
            _numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (_numero % _numeros[i] == 0)
                {
                    _contador++;
                }
            }

            Console.WriteLine($"El número tiene {_contador} divisores exactos entre los valores almacenados en el arreglo.");
            Console.ReadKey();
        }
    }
}
