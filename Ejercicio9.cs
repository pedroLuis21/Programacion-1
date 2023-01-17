using System;

namespace ConsoleApp1
{ 
      class Program9
    {
        static void Main(string[] args)
 
        {
           int _n;
            int _d3;
            int _d2;

            Console.WriteLine("Ingrese un numero de 4 digitos:");
            _n = Convert.ToInt32(Console.ReadLine());

         if (_n > 999 && _n < 10000){

            _d2 = (_n / 100) % 10;
            _d3 = (_n / 10) % 10;

            if (_d2 == _d3)
            {
                Console.WriteLine("El segundo digito es igual al penultimo digito");
            }
            else
            {
                Console.WriteLine("El segundo digito no es igual al penultimo digito.");
            }
              }
        
        else {Console.WriteLine("El numero debe contener 4 digitos");}
        
         } 

    }
}
