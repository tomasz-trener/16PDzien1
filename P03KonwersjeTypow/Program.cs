using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KonwersjeTypow
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string napis = "7";

            string napis2 = "8";
            // int32 przechowywany jest na 32 bitach co w pamieci daje nam mozliwosc
            // przechowywania wartosci od -2^31 do +2^31  , jeden bit przeznaczony na znak
            int napis3 = Convert.ToInt32(napis);
            int napis4 = Convert.ToInt32(napis2);

            int wynik1 = napis3 + napis4; // teraz mozemy przeprowazac operacje arytmetyczne

            int wynik2 = Convert.ToInt32(napis) + Convert.ToInt32(napis2);

            long duzaLiczba = 100; // maksymlnie 2^63 +/-

            short malaLiczba = 10;// maksymalnie 2^15 +/-

            int wiek = 10;
        }
    }
}