using System;
//Leer 10 números enteros, almacenarlos en un arreglo y calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo.

namespace Ejercicio9
{
class MainClass {
  public static int Factorial(int _n) {
    if (_n == 0) {
      return 1;
    }
    return _n * Factorial(_n - 1);
  }
    static void Main (string[] args) {
    int[] _Numeros = new int[10];
    int[] _Factoriales = new int[10];
    
    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un número: ");
      _Numeros[i] = int.Parse(Console.ReadLine());
      
      _Factoriales[i] = Factorial(_Numeros[i]);
    }
    
    Console.WriteLine("Los factoriales son: ");
    for (int i = 0; i < 10; i++) {
      Console.WriteLine(_Factoriales[i]);
    }
  }
}
}
