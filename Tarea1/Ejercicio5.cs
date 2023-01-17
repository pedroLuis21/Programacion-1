using System;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
 
        {
            int _N = 0;
    
            Console.WriteLine("Ingrese un numero de tres digitos: ");
            _N=Convert.ToInt32(Console.ReadLine());
           
           if (_N > 99 && _N < 1000) 
           {
             int _d3 = _N % 10;
             _N = _N / 10;
             int _d2 = _N % 10;
             int _d1 = _N / 10;
            
              if (_d1 != _d2 && _d1 != _d3 && _d2 != _d3)
              {
                if (_d1 > _d2){
                if (_d1 > _d3){Console.WriteLine("El digito mayor es "+ _d1 + " se encuentra en la posicion 1");}
                else{Console.WriteLine("El digito mayor es "+ _d3 + " se encuentra en la posicion 3");}
               }
    
             else{if (_d2 > _d3){Console.WriteLine("El digito mayor es "+ _d2 + " se encuentra en la posicion 2");}
                 else {Console.WriteLine("El digito mayor es "+ _d3 + " se encuentra en la posicion 3");}
                 }
               } 
         
             else {Console.WriteLine("Los digitos deben ser diferentes");}

            }
            else {Console.WriteLine("El numero debe tener tres digitos");
           };
 
        }
    }
}