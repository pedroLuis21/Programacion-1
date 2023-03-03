using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Garaje : Coche
    {
        private Coche auto;
        public string NombreAveria;
        public int CochesAtendidos = 0;
        private bool atenderCoche = true;
        private bool aceptarCoche=true;

        public Garaje(string marca, string modelo) : base(marca, modelo)
        {
        }

        public void AtenderCoche(Coche auto)
        {
            if (atenderCoche) { aceptarCoche = true; }
        }

        public void AceptarCoche (Coche auto, string NombreAveria)
        {
            if (aceptarCoche)
            {
                CochesAtendidos++;
                Precio_Averias_ACM =(new Random().NextDouble() * 100);
                aceptarCoche=false;
                atenderCoche = false;
            }
        }

        public void DevolverCoche()
        {
            aceptarCoche = true;
            atenderCoche = true;
        }

    }
}
