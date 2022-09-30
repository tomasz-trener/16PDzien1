using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Klasy
{
    internal class ZliczaczWyrazow
    {
        // ciało klasy

        // kod deklaratywny

        // w klasie mozemy zadeklarowac 4 rodzaje elementów

        //1) pola - określa jakie cechy ma dane narzędzie (obiekt)
        //2) właściwości - to samo co pole tylko bardziej rozbudowane
        //3) konstruktory - określa w jaki sposob tworzymy dany obiekt
        //4) metody - określają co dane narzedzie potrafi robic

        public ZliczaczWyrazow(string tekst)
        {
            Tekst = tekst;
        }

        public string Tekst { get; set; } // właściwość

        public int ZliczWyrazy(string wyraz)
        {
            string[] wyrazy = Tekst.Split(' ');
            int suma = 0;
            for (int i = 0; i < wyrazy.Length; i++)
                if (wyraz == wyrazy[i])
                    suma++;

            return suma;
        }
    }
}