using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class Secuencia: Compuesto
    {
        public override bool Ejecutar()
        {
            foreach (var hijo in hijos)
            {
                if (!hijo.Ejecutar())
                {
                    return false; // si un hijo falla, la secuencia falla
                }
            }
            return true;
        }
    }
}
