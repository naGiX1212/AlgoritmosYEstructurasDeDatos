namespace AlgoritmosYEstrucutrasDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila c = new Pila();
            Console.WriteLine("Agrego Elementos a la Pila");
            for (int i = 0; i < 10; i++)
            {
                c.ponerEnCola(i);
                Console.WriteLine(c.verTope());
            }
            Console.WriteLine("\nElimino elementos de la Pila");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(c.verTope());
                c.sacarDeCola();
            }
            
        }
    }
}
