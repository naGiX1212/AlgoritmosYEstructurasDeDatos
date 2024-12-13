using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmosYEstrucutrasDeDatos;

namespace AlgoritmosYEstructurasDeDatos
{
    
    public class Cola
    {
        private Nodo? nodoPri;
        private Nodo? nodoUlt;
        public void CrearCola()
        {
            nodoPri = null;
            nodoUlt = null;
        }
        public void PonerEnCola(int n)
        {
            Nodo nuevoNodo = new Nodo { n = n, Sig = null };

            if (nodoUlt == null) // Si la cola está vacía
            {
                nodoPri = nodoUlt = nuevoNodo; 
            }
            else
            {
                nodoUlt.Sig = nuevoNodo; 
                nodoUlt = nuevoNodo;
            }
        }
        public int? VerTope()
        {
            return nodoPri != null? nodoPri.n : null; 
        }

        public int? SacarDeCola()
        {
            if (nodoPri == null)
                return null;
            if (nodoPri == nodoUlt)
            {
                nodoPri = nodoUlt = null;
            }
            else
            {
                nodoPri = nodoPri.Sig;
            }
            
            return nodoPri?.n;

        }
    }
}
