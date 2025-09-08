using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal abstract class Compuesto: Nodo
    {
        protected List<Nodo> hijos = new List<Nodo>();

        public void AgregarHijo(Nodo hijo)
        {
            hijos.Add(hijo);
        }
    }
}
