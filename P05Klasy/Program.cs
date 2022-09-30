using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Klasy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int liczba = 4;

            string n = "";
            for (int i = 0; i < 10000; i++)
            {
                n = n + " heej " + i;
            }

            StringBuilder sb = new StringBuilder();

            DateTime dt = new DateTime(2000, 1, 1);

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("heej" + i);
            }

            string wynik = sb.ToString();
        }
    }
}