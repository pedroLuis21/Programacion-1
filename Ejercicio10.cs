using System;

namespace ConsoleApp1
{ 
      class Program10
    {
        static void Main(string[] args)
 
        {
           int _n1;
            int _n2;
            int _Nmin;
            int _Nmax;

            Console.WriteLine("Ingrese el primer numero:");
            _n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            _n2 = Convert.ToInt32(Console.ReadLine());
        
            if (_n1 > _n2)
            {
                _Nmax = _n1;
                _Nmin = _n2;
            }

            else
            {
                _Nmax = _n2;
                _Nmin = _n1;
            }
            if ((_Nmax - _Nmin) <= 10)
            {
                Console.WriteLine("La secuencia de numeros es: ");
                for (int i = _Nmin; i <= _Nmax; i++)
                {Console.WriteLine(i);}
            } 
            else 
            {Console.WriteLine("La diferencia entre los numeros es mayor a 10.");}
        
         } 

    }
}
