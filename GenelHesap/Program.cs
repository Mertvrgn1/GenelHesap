using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekiller hesapla = new Sekiller();

            Kare kare = new Kare(3);
            //kare.alanHesapla();
            //kare.cevreHesapla();

            Dikdortgen dikdortgen = new Dikdortgen(4, 5);
            //dikdortgen.alanHesapla();
            //dikdortgen.cevreHesapla();

            Ucgen ucgen = new Ucgen(3,5,2,6);
            //ucgen.alanHesapla();
            //ucgen.cevreHesapla();


            Hesapla(kare);
            Hesapla(dikdortgen);
            Hesapla(ucgen);



            Console.ReadKey();

        }

        private static void Hesapla(Sekiller sekil)
        {
            sekil.alanHesapla();
            sekil.cevreHesapla();
        }
    }
}
