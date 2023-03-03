using PracticaPOO;
using System;

namespace PracticaPOO
{
    public class PracticaPOO
    {
        public static void Main()
        {
            Garaje garaje1 = new Garaje(null, null);
            Garaje garaje2 = new Garaje(null, null);
            Coche coche1 = new Coche("Toyota", "Corolla");
            Coche coche2 = new Coche("Honda", "Civic");

            Console.WriteLine($"Coche 1. Marca= {coche1.marca} Modelo: {coche1.modelo}");
            Console.WriteLine($"Coche 2. Marca= {coche2.marca} Modelo: {coche2.modelo}");

            garaje1.AtenderCoche(coche1);
            garaje1.AceptarCoche(coche1, "Reparar motor");
            garaje1.DevolverCoche();
            garaje1.AtenderCoche(coche2);
            garaje1.AceptarCoche(coche2, "Cambio de gomas");
            Console.WriteLine($"Numero de coches atendidos en Garage 1: {garaje1.CochesAtendidos}");
            _ = garaje1.Precio_Averias_ACM;
            Console.WriteLine($"Precio averias: $ {garaje1.Precio_Averias_ACM}");

            garaje2.AtenderCoche(coche1);
            garaje2.AceptarCoche(coche1, "rotura motor");
            garaje2.DevolverCoche();
            garaje2.AtenderCoche(coche2);
            garaje2.AceptarCoche(coche2, "pinchadura de gomas");
            garaje2.DevolverCoche();
            garaje2.AtenderCoche(coche1);
            garaje2.AceptarCoche(coche1, "perdida de aceite");
            garaje2.DevolverCoche();
            Console.WriteLine($"Numero de coches atendidos en Garage 2: {garaje2.CochesAtendidos}");
            _ = garaje2.Precio_Averias_ACM;
            Console.WriteLine($"Precio averias: $ {garaje2.Precio_Averias_ACM}");
        }
    }
}