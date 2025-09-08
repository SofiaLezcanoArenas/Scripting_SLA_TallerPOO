using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class Raiz:Nodo
    {
        private Nodo hijo;

        public Raiz(Nodo hijo)
        {
            this.hijo = hijo;
        }

        public override bool Ejecutar()
        {
            if (hijo != null)
            {
                return hijo.Ejecutar();
            }
            return false;
        }
    }
}
