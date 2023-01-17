using System;

namespace ConsoleApp1
{
    class Program6 
    {
        static void Main(string[] args)
        {
             
            int _N;
            int _d1;
            int _d2;
            int _d3;

            Console.WriteLine("Ingrese un numero de 3 digitos:");
            _N = Convert.ToInt32(Console.ReadLine());
            if (_N > 99 && _N < 1000) 
           {
             _d1 = _N / 100;
             _d2 = (_N / 10) % 10;
             _d3 = _N % 10;

             if (_d1 % _d2 == 0 || _d2 % _d3 == 0 || _d1 % _d3 == 0 || _d2 % _d1 == 0 || _d3 % _d2 == 0 || _d3 % _d1 == 0)
             {Console.WriteLine("Uno de los digitos es multiplo de otro");}
            
             else {Console.WriteLine("Ninguno de los digitos es multiplo de otros.");}
            }
            
            else {Console.WriteLine("El numero debe tener tres digitos");}
        }
    }
}