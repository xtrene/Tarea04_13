using System;

namespace Tarea04_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu nombre:  ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido/a {0}", nombre);

            Console.ReadKey();
        }
    }
}
