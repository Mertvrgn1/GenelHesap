using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHesap
{
    public class Kare:Sekiller
    {
        public Kare(double kenar)
        {
            this.Kenar = kenar;
        }
        public Kare()
        {

        }
        public override void alanHesapla()
        {
            Console.WriteLine("Karenin alanı:" + (Kenar * Kenar));
        }
        public override void cevreHesapla()
        {
            Console.WriteLine("Karenin çevresi:"+(Kenar*4));
        }
    }
}
