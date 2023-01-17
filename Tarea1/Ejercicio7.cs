using System;

namespace ConsoleApp1
{
    class Program7
    {
        static void Main(string[] args)
 
        {
           int _n1 = 0;
           int _n2 = 0;
         

           Console.WriteLine("Escriba el primer numero: ");
            _n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            _n2 = Convert.ToInt32(Console.ReadLine());
            if (_n1 != _n2)
            {
                if (_n2 > _n1)
                {
                    Console.WriteLine($"Escriba el tercer numero: ");
                    _n1 = Convert.ToInt32(Console.ReadLine());
                }
                else if (_n1 > _n2)
                {
                    Console.WriteLine($"Escriba el tercer numero: ");
                    _n2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"El numero mas grande es {Math.Max(_n1, _n2)}");
            }
            else if (_n1 == _n2){
                Console.WriteLine($"Escriba el tercer numero: ");
                _n2 = Convert.ToInt32(Console.ReadLine());
                if (_n1 == _n2)
                {
                    Console.WriteLine("Los tres numeros son iguales.");
                }
                else { Console.WriteLine($"El numero mas grande de los tres es {Math.Max(_n1, _n2)}"); }
            }


        }
    }
}