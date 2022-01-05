using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHesap
{
    public class Ucgen:Sekiller
    {
        double h;
        double Kenar2;
        double Kenar3;

        public double _yukseklik 
        {
            get { return h; }
            set { h= value; }
        }

        public double _kenar2
        {
            get { return Kenar2; }
            set { Kenar2 = value; }
        }
        public double _kenar3
        {
            get { return Kenar3; }
            set { Kenar3 = value; }
        }
        public Ucgen()
        {

        }
        public Ucgen(double kenar,double kenar2,double kenar3,double h)
        {
            this.Kenar = kenar;
            this.Kenar2 = kenar2;
            this.Kenar3 = kenar3;
            this._yukseklik = h;
        }

        public override void alanHesapla()
        {
            Console.WriteLine("Üçgenin alanı:" + ((Kenar*h) / 2));
        }
        public override void cevreHesapla()
        {
            Console.WriteLine("Üçgenin çevresi:" + (Kenar+Kenar2+Kenar3));
        }
    }
}
