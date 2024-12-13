using AlgoritmosYEstructurasDeDatos;

namespace AlgoritmosYEstrucutrasDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////PILA
            Pila p = new Pila();
            Console.WriteLine("Agrego Elementos a la Pila");
            for (int i = 0; i < 10; i++)
            {
                p.ponerEnCola(i);
                Console.WriteLine(p.verTope());
            }
            Console.WriteLine("\nElimino elementos de la Pila");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(p.verTope());
                p.sacarDeCola();
            }
            ///////////COLA
            Cola c = new Cola();
            Console.WriteLine("Pongo elementos en la COLA : 0,1,2,3,4,5,6,7,8,9");
            for (int i = 0; i < 10; i++)
            {
                c.PonerEnCola(i);
            }
            Console.WriteLine("Elimino elementos de la COLA");
            for (int i = 0; i < 10; i++)
            {
                c.SacarDeCola();
                Console.WriteLine(c.VerTope());
            }

            
        }
    }
}
