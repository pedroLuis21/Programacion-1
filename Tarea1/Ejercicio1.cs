using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
 
        {
            int _N = 0;
            int _suma = 0;

            Console.WriteLine("Ingrese un numero de dos digitos: ");
            _N=Convert.ToInt32(Console.ReadLine());
           
           if (_N > 9 && _N < 100) {
           _suma = (_N / 10) + (_N % 10);
            Console.WriteLine("La suma de los digitos es igual a: " + _suma);
           }

           else {Console.WriteLine("El numero {0}", _N + " no es de dos digitos");
           };
 
        }
    }
}