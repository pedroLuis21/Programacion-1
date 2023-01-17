using System;

namespace ConsoleApp1
{
    class Program3
    {
        static void Main(string[] args)
 
        {
        int _n = 0;
        int[] nPrimos = {2,3,5,7};

            Console.WriteLine("Ingrese un numero de dos digitos: ");
            _n=Convert.ToInt32(Console.ReadLine());
           
            if (_n > 9 && _n < 100) 
               { 
                int _D1 = (_n / 10);
                int _D2 = (_n % 10);
                              
                if (nPrimos.Contains(_D1) && nPrimos.Contains(_D2)) {Console.WriteLine("Ambos digitos son Primos");} 
                 else 
                 { 
                     if (nPrimos.Contains(_D1)) {Console.WriteLine("El digito {0}", _D1 + " es primo.");}
                     else if (nPrimos.Contains(_D2)) {Console.WriteLine("El digito {0}", _D2 + " es primo.");}
                     else {Console.WriteLine("Ningun digito es primo.");}  
                 }
                }
            else {Console.WriteLine("El numero no es de 2 digitos");}
        
        }

    }
}
