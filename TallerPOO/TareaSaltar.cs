using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class TareaSaltar: Tarea
    {
        public override bool Ejecutar()
        {
            Console.WriteLine("No se pudo mover al objetivo, ¡saltando!");
            return true;
        }
    }
}
