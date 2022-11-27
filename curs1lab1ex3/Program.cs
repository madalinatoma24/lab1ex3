using System;

namespace curs1lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura
           */

            long number;
            Console.WriteLine("Introduceti numarul: ");
            number = long.Parse(Console.ReadLine());

            long result = number %10;

            Console.WriteLine("Ultima cifra este: " + result);
        }
    }
}
