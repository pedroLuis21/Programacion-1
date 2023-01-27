using System;

// Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.
namespace Ejercicio3
{

class MainClass {
  static void Main (string[] args) {
    int[] _N = new int[10];
    int _Max = int.MinValue;
    int _Position = -1;
    
    for (int i = 0; i < 10; i++) {
      Console.Write("Ingrese un número entero: ");
      _N[i] = int.Parse(Console.ReadLine());
      if (_EsPrimo(_N[i])) {
        if (_N[i] > _Max) {
          _Max = _N[i];
          _Position = i;
        }
      }
    }
    
    if(_Position != -1) {
        Console.WriteLine($"El número primo mayor es {_Max} y se encuentra en la posición {_Position}.");
    } else {
        Console.WriteLine("No se ha ingresado ningún número primo");
    }
  }
  
  public static bool _EsPrimo(int _n) {
    if (_n <= 1) return false;
    if (_n == 2) return true;
    if (_n % 2 == 0) return false;

    for (int i = 3; i <= Math.Sqrt(_n); i += 2) {
        if (_n % i == 0) return false;
    }
    return true;
  }
 }
}
