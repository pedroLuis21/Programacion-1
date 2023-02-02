using System;
//  Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _numeros = new int[10];
            int _contador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");
                _numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                int _primo = _numeros[i];
                while (_primo >= 10)
                {
                    _primo = _primo / 10;
                }
                if (esPrimo(_primo))
                {
                    _contador++;
                }
            }

            Console.WriteLine($"Hay {_contador} números que comienzan con un dígito primo.");
            Console.ReadKey();
        }

        static bool esPrimo(int _num)
        {
            if (_num <= 1)
            {
                return false;
            }
            for (int i = 2; i < _num; i++)
            {
                if (_num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
