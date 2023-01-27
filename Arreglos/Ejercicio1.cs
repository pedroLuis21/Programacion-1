using System;

//  Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.

namespace Ejercicio1
{
class MainClass {
  public static void Main (string[] args) {
    int[] _N = new int[10];
    int _Max = int.MinValue;
    int _Position = -1;
    
    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un número: ");
      _N[i] = int.Parse(Console.ReadLine());
      
      if (_N[i] >_Max) {
        _Max = _N[i];

        _Position = i;
      }
    }
    
    Console.WriteLine($"El número mas grande es {_Max} y se encuentra en la posición {_Position} " );
   }
 }
}
