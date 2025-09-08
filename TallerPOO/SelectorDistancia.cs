using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class SelectorDistancia: Selector
    {
        private int distanciaValida;
        private Estado estado;
        public SelectorDistancia(Estado estado, int distanciaValida)
        {
            this.estado = estado;
            this.distanciaValida = distanciaValida;
        }

        public bool Evaluar()
        {
            int distancia = Math.Abs(estado.PosicionActual - estado.PosicionObjetivo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Evaluando distancia... (Distancia = {distancia}, Distancia Válida = {distanciaValida})");
            Console.ResetColor();
            return distancia > 0 && distancia <= distanciaValida;
        }

        public override bool Ejecutar()
        {
            if (Evaluar())
            {
                // Si la condición se cumple, ejecuta su hijo (TareaMover)
                return base.Ejecutar();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Distancia no válida, no se ejecuta la tarea.");
            Console.ResetColor();
            return false;
        }
    }
}
