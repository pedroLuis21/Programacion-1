//Decifrar mensaje cifrado en ROT13
// Pedro Luis Rosario 22-0972
using System;

namespace Parcial_Decodificar_ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codificar o descodificar ROT13 \n");

            Console.WriteLine("Ingrese el mensaje que desea Codificar o Decodificar en ROT13: ");
            string _MIngresado = Console.ReadLine();

         while (!Mayuscula(_MIngresado))
            {
                Console.WriteLine("Todos los caracteres deben estar en Mayuscula. Ingrese una nueva cadena: ");
                _MIngresado = Console.ReadLine();
            }
         string _MEgresado = ROT13(_MIngresado);
            Console.WriteLine($"El mensaje obtenido es: {_MEgresado}");
            Console.ReadKey();
        }

        static string ROT13(string _MIngresado)
        {
            char[] caracteres = _MIngresado.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                char caracter = caracteres[i];

                if (caracter >= 'A' && caracter <= 'Z')
                {
                    caracter = (char)((caracter - 'A' + 13) % 26 + 'A');
                }
                 
                caracteres[i] = caracter;
             
            }

            return new string(caracteres);
        }

           static bool Mayuscula(string cadena)
           {
            foreach (char c in cadena)
            {
                if (char.IsLower(c))
                {
                    return false;
                }
            }
            return true;
    
          }
    }
}
