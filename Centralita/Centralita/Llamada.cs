using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        public string _NumberSrc { get; set; }
        public string _NumberDst { get; set; }
        public int _Duracion { get; set; }
        public double _Costo { get; set; }

        public Llamada(string origen, string destino, int duracion, double costo)
        {
            this._NumberSrc = origen;
            this._NumberDst = destino;
            this._Duracion = duracion;
            this._Costo = costo;
        }

        public virtual void CalcularCosto()
        {
            
        }





    }
}
