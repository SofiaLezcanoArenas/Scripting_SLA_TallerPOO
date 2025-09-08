using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class Selector: Compuesto
    {
        public override bool Ejecutar()
        {
            foreach (var hijo in hijos)
            {
                if (hijo.Ejecutar())
                {
                    return true; // retornaría éxito si algún hijo se ejecuta exitosamente
                }
            }
            return false;
        }
    }
}
