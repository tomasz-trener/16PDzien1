using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieZliczacz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Program do zliczania wyrazow");

            string nazwaPliku = "mojPlik.txt";

            int suma = 0;
            while (suma == 0)
            {
                Console.WriteLine("Podaj jaki wyraz szukasz");

                string wyraz = Console.ReadLine();

                string tekst = File.ReadAllText(nazwaPliku);

                string zmienna1 = "ala";
                string zmienna2 = "ma";
                string zmienna3 = "kota";

                string[] tablica = new string[3];
                tablica[0] = "ala";
                tablica[1] = "ma";
                tablica[2] = "kota";

                string[] wyrazy = tekst.Split(' ');

                for (int i = 0; i < wyrazy.Length; i++)
                {
                    if (wyraz == wyrazy[i])
                    {
                        suma++;
                    }
                }

                string raport = "wyraz " + wyraz + " wystepuje " + suma + " razy.";
                Console.WriteLine(raport);
            }

            Console.ReadKey();
        }
    }
}