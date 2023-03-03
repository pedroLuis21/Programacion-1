using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Motor
    {
        private int litros_de_aceite {get;set;}
        private int Potencia {get;set;}

        public Motor(int Potencia)
        {
            this.litros_de_aceite = 0;
            this.Potencia = Potencia;
        }

    }
}
