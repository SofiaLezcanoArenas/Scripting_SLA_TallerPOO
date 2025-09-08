using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class TareaMover: Tarea
    {
        private Estado estado;

        public TareaMover(Estado estado)
        {
            this.estado = estado;
        }

        public override bool Ejecutar()
        {
            Console.WriteLine("Iniciando movimiento hacia el objetivo...");

            while (estado.PosicionActual < estado.PosicionObjetivo)
            {
                estado.PosicionActual++;
                Console.WriteLine($"Posición actual: {estado.PosicionActual}");
                Thread.Sleep(500);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Se alcanzó la posición objetivo!");
            Console.ResetColor();
            return true;
        }
    }
}
