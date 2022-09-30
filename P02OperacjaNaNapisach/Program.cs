using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjaNaNapisach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string napis = "ala ma kota i ma psa";
            //              012345678910    od pozycji 4 wziac 2 znaki
            string napis2 = napis.ToUpper();

            string napis3 = napis.ToLower();

            string napis4 = napis.Substring(4, 2); // ma

            string napis5 = napis.Substring(7, 4); // kota
            string napis6 = napis.Substring(7); // kota

            int dlugosc = napis.Length; // 11

            int pozycja = napis.IndexOf("ma"); // 4

            char znak = 'k'; // znaki podajemy w apostrofach a napisy w cudzyslowiu

            int pozycja2 = napis.IndexOf(znak);

            string napis7 = napis.Replace("ma", "bedzie miala");

            bool czyZawiera = napis.Contains("ma"); // true

            bool innaZmienna = false; // ta zmienna przechowuje nieprawdę

            string napis8 = "   ala   ";

            string napis9 = napis8.Trim(); // usuwa spacje

            string napis10 = "ala" + " ma " + "kota"; //ala ma kota

            int wiek = 30;
            string imie = "Ala";

            string raport = imie + " ma " + wiek + " lat";

            string zmienna11 = "cokolwiek" + wiek; // konwersja niejawna
            string zmienna12 = "cokolwiek" + Convert.ToString(wiek); // konwersja jawna

            Console.WriteLine(napis2);

            Console.ReadKey();
        }
    }
}