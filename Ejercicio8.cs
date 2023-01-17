using System;

namespace ConsoleApp1
{ 
      class Program8
    {
        static void Main(string[] args)
 
        {
           
             int _N;
             int _suma = 0;
             int _x;

             Console.WriteLine("Ingrese un numero de cinco digitos: ");
             _N=Convert.ToInt32(Console.ReadLine());
             if (_N > 9999 && _N < 100000){
            
             _x = _N;
              while (_N > 0)
             {
                _suma = _suma * 10 + (_N % 10);
                _N = _N/10;
             }
              if (_suma == _x){
                Console.WriteLine("El numero es capicua");
             }
            else{
                Console.WriteLine("El numero no es capicua");
             }
                }
        else {Console.WriteLine("El numero no es de cinco digitos");}
        
         } 

    }
}

