using System;
// Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo

namespace Ejercicio7
{
class MainClass {
  public static void Main (string[] args) {
    int[] _N = new int[10];
    int _Sum = 0;
    
    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un número entero: ");
      _N[i] = int.Parse(Console.ReadLine());
      
      _Sum += _N[i];
    }
    
    int _Promedio = _Sum / 10;
    Console.WriteLine($"El promedio es igual a: {_Promedio}.");
  }
}
}
