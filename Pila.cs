using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosYEstrucutrasDeDatos
{
    class Pila
    {
        private Nodo? act;
       public void crearCola()
        {
            act = null;              
        }
        public Nodo ponerEnCola(int n)
        {
            Nodo nodo = new Nodo
            {
                n = n,
                Sig = act
            };
           
            act = nodo;
            return act;
        }
        public int? verTope()
        {
            if (this.act == null)
                return null;
            else
                return this.act.n;
        }
        public Nodo? sacarDeCola()
        {
            if(act == null)
                return null;
            this.act = act.Sig;
            return act;
        }
        public void eliminarCola()
        {
            while (act != null) { 
                act = act.Sig;
            }
        }

    }
}
