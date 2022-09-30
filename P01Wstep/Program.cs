using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Wstep
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string napis = "ala ma kota";
            int liczba = 5;

            napis = "7";

            napis = napis + "3"; // konkatenacja stringow, wynik 73

            /* dlugi komentarz
             wielo
            liniowy
            */

            liczba = liczba + 3; // wynik 8

            Console.WriteLine(napis);
            Console.WriteLine(liczba);

            Console.ReadKey();
        }
    }
}