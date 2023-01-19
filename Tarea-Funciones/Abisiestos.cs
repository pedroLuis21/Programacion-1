using System;

namespace ConsoleApp1
{
        class Program
    {

        static bool _Bisiesto(int _Year)
        {
         if (_Year % 4 == 0 && (_Year % 100 !=0 || _Year % 400 == 0))
             return true;

        else
            return false;
        }

        static void Main(string[] args)
       {
             string _Y;
             int _N; 
             bool _result;
        
             Console.WriteLine("Verificar Años bisiestos");
             Console.WriteLine("Ingrese el año que desea verificar: ");
                do
                 {
                     _Y = Console.ReadLine();
                     _result= int.TryParse(_Y, out _N);
                  if (!_result){Console.WriteLine("El valor ingresado no es un numero. Favor ingresar un numero para continuar:  ");}

                  }
                    while (!_result);
                    
             
              if (_Bisiesto(_N) == true)
              {
                Console.WriteLine("El año "+ _Y + " es bisiesto");
              }
              else 
              {
                Console.WriteLine("El año "+ _Y + " no es bisiesto");
               }
             
             Console.WriteLine("Presiona una tecla para salir del programa");
             Console.ReadKey();

        }
    }
} 
