using System;


namespace Numeroifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            if (x > 0)
            {
                Console.WriteLine("Número positivo ");
            }
            else if (x < 0)
            {
                Console.WriteLine("Número negativo");
            }
            else
            {
                Console.WriteLine("´Número zero");
            }
                Console.WriteLine("Fim do Programa");
                Console.ReadKey();
        }
            
    }
}
