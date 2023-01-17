using System;

namespace ConsoleApp1
{
    class Program4
    {
        static void Main(string[] args)
 
        {
            int _N1 = 0;
            int _N2 = 0;
            int _suma = 0;

            Console.WriteLine("Ingrese un numero de dos digitos: ");
            _N1=Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Ingrese otro numero de dos digitos: ");
            _N2=Convert.ToInt32(Console.ReadLine());


           if ((_N1 > 9 && _N1 < 100) && (_N2 > 9 && _N2 < 100)) 
           {
              _suma = _N1 + _N2;
              
              if (_suma % 2 == 0) {Console.WriteLine("El resultado de la suma es par: " + _suma);}
              else {Console.WriteLine("El resultado de la suma no es par: " + _suma);}
           }

           else {Console.WriteLine("Los numeros deben tener dos digitos");
           };
 
        }
    }
}