using System;
//Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos
namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _numeros = new int[10];
            int _contador = 0;

            Console.WriteLine("Ingrese 10 números:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                _numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los números con más de 3 dígitos se encuentran en las posiciones:");
            for (int i = 0; i < 10; i++)
            {
                if (_numeros[i] >= 100 && _numeros[i] <= 999)
                {
                    Console.WriteLine(i + 1);
                    _contador++;
                }
            }

            if (_contador == 0)
            {
                Console.WriteLine("No se encontraron números con más de 3 dígitos.");
            }

            Console.ReadKey();
        }
    }
}
