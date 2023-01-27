using System;
// Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.

namespace Ejercicio8
{
class MainClass {
  static void Main (string[] args) {
    int[] _n = new int[10];
    int _CNegativo = 0;
    
    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un número: ");
      _n[i] = int.Parse(Console.ReadLine());
      
      if (_n[i] < 0) {
        _CNegativo++;
      }
    }
    
    Console.WriteLine($"Hay {_CNegativo} números negativos.");
  }
}
}
