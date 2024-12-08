namespace AlgoritmosYEstrucutrasDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();
            Console.WriteLine("Agrego Elementos a la Cola");
            for (int i = 0; i < 10; i++)
            {
                c.ponerEnCola(i);
                Console.WriteLine(c.verTope());
            }
            Console.WriteLine("\nElimino elementos de la Cola");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(c.verTope());
                c.sacarDeCola();
            }
            
        }
    }
}
