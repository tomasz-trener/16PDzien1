using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Daty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int liczby = 5;
            string napisy = "ala ma kota";
            char znaki = 'h';
            bool wartosciLogiczne = true;

            //value types (typy wartosciowe, inaczej proste)

            //complex types

            DateTime data1 = new DateTime(2022, 9, 29);

            DateTime data2 = new DateTime(2022, 9, 29, 12, 5, 10);

            DateTime data3 = DateTime.Now;

            int dzien = data3.Day;
            int miesica = data3.Month;
            int rok = data3.Year;

            DateTime data4 = data3.AddDays(10);

            string raport = Convert.ToString(data4);
            Console.WriteLine(raport);

            TimeSpan roznica = new DateTime(2022, 12, 31) - DateTime.Now;

            double ileDni = roznica.TotalDays;

            double zmiennaNiecakowita = 5.5;

            Console.WriteLine(ileDni);

            Module1

            Console.ReadKey();
        }
    }
}