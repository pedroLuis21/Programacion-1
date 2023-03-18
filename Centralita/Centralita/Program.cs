using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Centralita
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita();

            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("  Bienvenidos a la Central Telefonica  ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Agregar llamada local");
                Console.WriteLine("2. Agregar llamada provincial");
                Console.WriteLine("3. Mostrar llamadas registradas");
                Console.WriteLine("4. Calcular facturación total");
                Console.WriteLine("5. Mostrar Informe");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Opcion: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese número de origen:");
                        string origenLocal = Console.ReadLine();

                        Console.WriteLine("Ingrese número de destino:");
                        string destinoLocal = Console.ReadLine();

                        Console.WriteLine("Ingrese duración de la llamada (en segundos):");
                        int duracionLocal = int.Parse(Console.ReadLine());

                        LlamadaLocal llamadaLocal = new LlamadaLocal(origenLocal, destinoLocal, duracionLocal);
                        centralita.RegistrarLlamada(llamadaLocal);

                        Console.WriteLine("Llamada local agregada correctamente.");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese número de origen:");
                        string origenProv = Console.ReadLine();

                        Console.WriteLine("Ingrese número de destino:");
                        string destinoProv = Console.ReadLine();

                        Console.WriteLine("Ingrese duración de la llamada (en segundos):");
                        int duracionProv = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese franja horaria (1, 2 o 3):");
                        int franjaHoraria = int.Parse(Console.ReadLine());

                        LlamadaProv llamadaProv = new LlamadaProv(origenProv, destinoProv, duracionProv, franjaHoraria);
                        centralita.RegistrarLlamada(llamadaProv);

                        Console.WriteLine("Llamada provincial agregada correctamente.");
                        break;

                    case 3:
                        Console.WriteLine("Llamadas registradas:");
                        centralita.MostrarLlamadas();
                        break;

                    case 4:
                        double facturacionTotal = centralita.CalcularFacturacionTotal();
                        Console.WriteLine($"La facturación total es de {facturacionTotal} DOP.");
                        break;

                    case 5:
                        Console.WriteLine("Informe de facturación:");
                        Console.WriteLine("----------------------");
                        Console.WriteLine($"Número total de llamadas: {centralita.NumeroTotalLlamadas()}");
                        Console.WriteLine($"Facturación total: RD${centralita.CalcularFacturacionTotal():F2}");
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor ingrese una opción del menú.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

