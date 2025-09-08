using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class TareaEsperar: Tarea
    {
        private int tiempoEspera;

        public TareaEsperar(int tiempoEspera)
        {
            this.tiempoEspera = tiempoEspera;
        }

        public override bool Ejecutar()
        {
            Console.WriteLine($"Esperando {tiempoEspera} segundos...");
            Thread.Sleep(tiempoEspera * 1000);
            return true;
        }
    }
}
