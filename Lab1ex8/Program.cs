
using System;

namespace Lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y. */

            Console.WriteLine("Introduceti x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y");
            int y = int.Parse(Console.ReadLine());

          
            if (x % y == 0)  Console.WriteLine("Divizibil");
            else Console.WriteLine("Indivizibil");

        }
    }
}
