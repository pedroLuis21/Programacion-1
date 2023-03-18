using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        public List<Llamada> llamadas { get; set; }

        public Centralita()
        {
            this.llamadas = new List<Llamada>();
        }

        public void RegistrarLlamada(Llamada llamada)
        {
            this.llamadas.Add(llamada);
        }
        public int NumeroTotalLlamadas()
        {
            return llamadas.Count;
        }

        public double CalcularFacturacionTotal()
        {
            double facturacionTotal = 0;

            foreach (Llamada llamada in this.llamadas)
            {
                llamada.CalcularCosto();
                facturacionTotal += llamada._Costo;
            }

            return facturacionTotal;
        }

        public void MostrarLlamadas()
        {
            foreach (Llamada llamada in this.llamadas)
            {
                llamada.CalcularCosto();
                Console.WriteLine($"Número origen: {llamada._NumberSrc}, Número destino: {llamada._NumberDst}, Duración: {llamada._Duracion} segundos, Costo: {llamada._Costo} DOP");
        }
        }
    }
}
