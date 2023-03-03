using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Coche
    {
      private Motor motor { get;}
      public string marca { get;  set;}
      public string modelo { get; set; }
      public double Precio_Averias_ACM { get; set; }

        public Coche(string marca, string modelo) 
        {
            this.motor = new Motor(0);
            this.marca = marca;
            this.modelo = modelo;
            this.Precio_Averias_ACM = 0;
        }
        public void Averia_Acumulado(double importe) 
        { 
            Precio_Averias_ACM += importe;
            
        }


    }
}
