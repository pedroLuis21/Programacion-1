using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class LlamadaProv:Llamada
    {
            public int _FranjaHoraria { get; set; }

            public LlamadaProv(string origen, string destino, int duracion, int franjaHoraria) : base(origen, destino, duracion, 0)
            {
                this._FranjaHoraria = franjaHoraria;
            }

            public override void CalcularCosto()
            {
                switch (this._FranjaHoraria)
                {
                    case 1:
                        this._Costo = this._Duracion * 0.2;
                        break;
                    case 2:
                        this._Costo = this._Duracion * 0.25;
                        break;
                    case 3:
                        this._Costo = this._Duracion * 0.3;
                        break;
                    default:
                        Console.WriteLine("Franja horaria no válida");
                        break;
                }


            }
        }

    }

