using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Klasy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            StringBuilder sb2 = new StringBuilder("ala"); // uzycie konstruktora
            sb.Append("ma"); // uzycie metody

            int dlugosc = sb.Length; // uzycie wlasciwosci

            ZliczaczWyrazow zw = new ZliczaczWyrazow("ala ma kota");

            // zw.Tekst = "ala ma kota";

            //string s = zw.Tekst;

            int w = zw.ZliczWyrazy("ma");
            Console.WriteLine(w);

            w = zw.ZliczWyrazy("kota");
            Console.WriteLine(w);

            w = zw.ZliczWyrazy("sam");
            Console.WriteLine(w);

            Console.ReadKey();
        }
    }
}