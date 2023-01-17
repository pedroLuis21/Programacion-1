using System;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
 
        {
            int _n = 0;
            int[] nPrimos = {11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97};

            Console.WriteLine("Ingrese un numero de dos digitos: ");
            _n=Convert.ToInt32(Console.ReadLine());
           
           if (_n < 0){ Console.WriteLine("El numero es negativo");}
           
           else { 
            if (_n > 9 && _n < 100) 
               { if (nPrimos.Contains(_n)) { Console.WriteLine("El numero {0}", _n + " es primo.");} 
                 else {Console.WriteLine("El numero {0}", _n + " no es primo.");}
                }
            else {Console.WriteLine("El numero no es de 2 digitos");}

           }
 
        }
    }
}