using System;

//  Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.

namespace Ejercicio2
{
 class MainClass2 
{
  static void Main (string[] args) {
    int[] _N = new int[10];
    int _Max = int.MinValue;
    int _Position = -1;
    
    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un número entero: ");
      _N[i] = int.Parse(Console.ReadLine());
      
      if (_N[i] > _Max && _N[i] % 2 == 0) {
        _Max = _N[i];
        _Position = i;
      }
    }
    
    if(_Position != -1) {
        Console.WriteLine($"El número par mayor es {_Max} y se encuentra en la posición {_Position}");
    } else {
        Console.WriteLine("No se ha ingresado ningún número par");
    }
  }
}

}
