using System;

// Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición se encuentra el número primo con mayor cantidad de dígitos pares.
namespace Ejercicio5
{
class Program
{
    static void Main()
    {
        int[] _N = new int[10];
        int _MaxDiPares = 0;
        int _Position = -1;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero entero: ");
            _N[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            int _DigitosPares = 0;
            int _NActual = _N[i];

            if (_EsPrimo(_NActual))
            {
                while (_NActual > 0)
                {
                    int _LastDigit = _NActual % 10;
                    if (_LastDigit % 2 == 0)
                    {
                        _DigitosPares++;
                    }
                    _NActual /= 10;
                }

                if (_DigitosPares > _MaxDiPares)
                {
                    _MaxDiPares = _DigitosPares;
                    _Position = i;
                }
            }
        }

        if (_Position == -1)
        {
            Console.WriteLine("No se ingresaron numeros primos");
        }
        else
        {
            Console.WriteLine($"El numero primo con mayor cantidad de digitos pares esta en la posicion: {_Position} ");
        }
    }

    static bool _EsPrimo(int _n)
    {
        if (_n <= 1) return false;
        if (_n == 2) return true;
        if (_n % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(_n));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (_n % i == 0) return false;
        }

        return true;
    }
}
}
