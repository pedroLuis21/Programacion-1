using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class LlamadaLocal : Llamada
    {
        public LlamadaLocal(string origen, string destino, int duracion) : base(origen, destino, duracion, 0)
        {
        }

        public override void CalcularCosto()
        {
            this._Costo = this._Duracion * 0.15;
        }
    }

    
}

